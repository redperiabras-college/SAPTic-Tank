using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Linq.Enumerable;
using System.Text.RegularExpressions;

namespace SAPtic_Tank
{
    /// <summary>
    /// Class where checking and reading data is being done
    /// </summary>
    public static class Assembler
    {
        /// <summary>
        /// RAM Class where command and data are being stored
        /// </summary>
        private static RAM ram = new RAM();

        /// <summary>
        /// Function that processes tokens and stores command and data in the ram
        /// </summary>
        public static void assemble(string data)
        {
            string[] input = data.Split('\n');
            int MAIN_ADDRESS = 0;

            for(int line = 0; line < input.Length; line++)
            {
                string[] tokens = input[line].Split();

                int LINE_NUM = line + 1;
                string COMMAND = tokens[0];


                if (COMMAND.Equals("ORG"))
                {
                    //check for unexpected tokens
                    if (Checker.check_unexpected_token(tokens[3]))
                    {
                         throw new ArgumentException("Error: Unexpected " + tokens[3] + " in line " + LINE_NUM);
                    }
                                
                    if (tokens[2].Equals("MAIN"))
                        {
                            string HEX_ADDRESS = tokens[1].Substring(0, 2);

                            if (Checker.check_hex(HEX_ADDRESS))
                            {
                                MAIN_ADDRESS = Convert.ToInt32(HEX_ADDRESS, 2);
                            }
                            else
                            {
                                throw new ArgumentException("Error : Invalid Address in line " + LINE_NUM + "\n"
                                    + "Hint: Available RAM Addresses are from 00H to 0FH only");
                            }
                        }
                        else
                        {
                            string ADDRESS = tokens[1].Substring(0, 2);
                            string DATA = tokens[2].Substring(0, 2);

                            if (Checker.check_hex(ADDRESS))
                            {
                                if (Checker.check_data(DATA))
                                    try
                                    {
                                        ram.set_data(ADDRESS, DATA);
                                    }
                                    catch(ArgumentException e)
                                    {
                                        throw new ArgumentException("Error : " + e.Message + " in line " + LINE_NUM);
                                    }
                                else
                                {
                                    throw new ArgumentException("Error : Invalid Data in line " + LINE_NUM + "\n"
                                        + "Hint: SAP1 can only accept inputs in range of 0 to 127");
                                }
                            }
                            else
                            {
                                throw new ArgumentException("Error : Invalid Address in line " + LINE_NUM + "\n"
                                        + "Hint: Available RAM Addresses are from 00H to 0FH only");
                            }
                        }
                    }
                    else if (COMMAND.Equals("MAIN:"))
                    {
                        continue;
                    }
                    else if (COMMAND.Equals("LDA"))
                    {
                        string HEX_ADDRESS = tokens[1].Substring(0, 2);

                        if (Checker.check_hex(HEX_ADDRESS))
                            try
                            {
                                ram.set_command(MAIN_ADDRESS++, "00", HEX_ADDRESS);
                            }
                            catch(ArgumentException e)
                            {
                                throw new ArgumentException("Error : " + e.Message + " in line " + LINE_NUM);
                            }
                        else
                            throw new ArgumentException("Error : Invalid Address in line " + LINE_NUM + "\n"
                                        + "Hint: Available RAM Addresses are from 00H to 0FH only");
                    }
                    else if (COMMAND.Equals("ADD"))
                    {
                        string HEX_ADDRESS = tokens[1].Substring(0, 2);

                        if (Checker.check_hex(HEX_ADDRESS))
                        {
                            try
                            {
                                ram.set_command(MAIN_ADDRESS++, "00", HEX_ADDRESS);
                            }
                            catch (ArgumentException e)
                            {
                                throw new ArgumentException("Error : " + e.Message + " in line " + LINE_NUM);
                            }
                        }
                        else
                            throw new ArgumentException("Error : Invalid Address in line " + (line + 1) + "\n"
                                        + "Hint: Available RAM Addresses are from 00H to 0FH only");
                    }
                    else if (COMMAND.Equals("SUB"))
                    {
                        string HEX_ADDRESS = tokens[1].Substring(0, 2);

                        if (Checker.check_hex(HEX_ADDRESS))
                        {
                            try
                            {
                                ram.set_command(MAIN_ADDRESS++, "00", HEX_ADDRESS);
                            }
                            catch (ArgumentException e)
                            {
                                throw new ArgumentException("Error : " + e.Message + " in line " + LINE_NUM);
                            }
                        }  
                        else
                            throw new ArgumentException("Error : Invalid Address in line " + LINE_NUM + "\n"
                                        + "Hint: Available RAM Addresses are from 00H to 0FH only");
                    }
                    else if (COMMAND.Equals("OUT"))
                    {
                        try
                        {
                            ram.set_command(MAIN_ADDRESS++, "0E", "0F");
                        }
                        catch (ArgumentException e)
                        {
                            throw new ArgumentException("Error : " + e.Message + " in line " + LINE_NUM);
                        }
                    }
                    else if (COMMAND.Equals("HLT"))
                    {
                        try
                        {
                            ram.set_command(MAIN_ADDRESS++, "0F", "0F");
                        }
                        catch (ArgumentException e)
                        {
                            throw new ArgumentException("Error : " + e.Message + " in line " + LINE_NUM);
                        }
                        
                    }
                    else if (COMMAND.Equals(""))
                    {
                        continue;
                    }
                    else {
                        throw new ArgumentException("Error : Invalid " + COMMAND + " command in line " + LINE_NUM);
                    }
                }
            }

        public static string getRAM()
        {
            return ram.get();
        }
    }

    /// <summary>
    /// Class to check every given codes to assemble
    /// </summary>
    public static class Checker
    {
        private static string INVALID_HEX_EXP = @"[^\dabcdef]";
        private static string HEX_PADDING_EXP = @"^(0x)H?0*H";

        /// <summary>
        /// Checks if given opcode and address is valid
        /// </summary>
        /// <param name="hex"></param>
        /// <returns>true if valid </returns>
        public static bool check_hex(string hex)
        {
            hex = Regex.Replace(hex.Trim().ToLower(), HEX_PADDING_EXP, "");

            if (Regex.IsMatch(hex, INVALID_HEX_EXP))
                return false;
            else
            {
                int INT_OPCODE = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);

                if (INT_OPCODE > 15)
                    return false;
                else
                    return true;
            }
        }

        public static bool check_data(string hex_data)
        {
            hex_data = Regex.Replace(hex_data.Trim().ToLower(), HEX_PADDING_EXP, "");

            if (Regex.IsMatch(hex_data, INVALID_HEX_EXP))
                return false;
            else
            {
                int INT_DATA = int.Parse(hex_data, System.Globalization.NumberStyles.HexNumber);

                if (INT_DATA > 127)
                    return false;
                else
                    return true;
            }
        }

        public static bool check_unexpected_token(string token)
        {
            if(token.Length == 0)
                return false;
            else if (token.Substring(0,1).Equals(";"))
                return false;
            else
                return true;
        }
    }
}
