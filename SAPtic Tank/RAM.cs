using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPtic_Tank
{
    class RAM
    {
        //RAM
        /// <summary>
        /// Class that represents 16x8 RAM
        /// </summary>
        /// 

        private static int RAM_SIZE = 16;
        private static int RAM_CONTENT = 2;

        private static string[,] memory = new string[RAM_SIZE, RAM_CONTENT];

        /// <summary>
        /// RAM constructor that initializes RAM addresses in Axxxx format
        /// </summary>
        public RAM()
        {
            for (int i = 0; i < RAM_SIZE; i++)
            {
                memory[i, 0] = "A" + Convert.ToString(i, 2).PadLeft(4, '0');
            }
        }

        /// <summary>
        /// Converts Hex to Bin
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private string hexbin(string hex)
        {
            return Convert.ToString(Convert.ToInt32(hex, 16), 2).PadLeft(4, '0');
        }

        /// <summary>
        /// Converts Hex to Dec
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private int hexdec(string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

        /// <summary>
        /// Converts Dec to Bin
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        private string decbin(int dec)
        {
            return Convert.ToString(dec,2);
        }

        /// <summary>
        /// Check if the requested address is empty
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        private bool address_is_empty(int address)
        {
            if (memory[address, 1] == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Function that assemble all of the input data into the ram
        /// </summary>
        /// <param name="dec_address">Target mmory address</param>
        /// <param name="hex_command">SAP1 mnemonics in xxH or Hex form</param>
        /// <param name="hex_data">Data that will be assembled to the said memory address</param>
        public void set_command(int dec_address, string hex_command, string hex_data)
        {
            //set command
            string BINARY_ADDRESS = decbin(dec_address);
            string BINARY_COMMAND = hexbin(hex_command);
            string BINARY_DATA = hexbin(hex_data);

            if (address_is_empty(dec_address))
            {
                //set address
                if (!hex_data.Equals(""))
                    memory[dec_address, 1] += BINARY_COMMAND + BINARY_DATA;
                else
                    memory[dec_address, 1] = BINARY_COMMAND;
            }
            else
                throw new System.ArgumentException("Requested RAM Address " + BINARY_ADDRESS + " is not available");

        }

        /// <summary>
        /// For ORGanizing the data to our 16x8 RAM given an address
        /// </summary>
        /// <param name="hex_address">Target address in HEX format</param>
        /// <param name="hex_data">Data to be assembled to the said memory address</param>
        public void set_data(string hex_address, string hex_data)
        {
            int DEC_ADDRESS = hexdec(hex_address);
            string BINARY_ADDRESS = hexbin(hex_address);
            string BINARY_DATA = hexbin(hex_data);

            if (address_is_empty(hexdec(hex_address)))
            {
                memory[DEC_ADDRESS, 1] = BINARY_DATA.PadLeft(8, '0');
            }
            else
                throw new System.ArgumentException("Requested RAM Address " + BINARY_ADDRESS + " is not available");

        }

        /// <summary>
        /// Function that returns the content of RAM
        /// </summary>
        /// <returns>RAM Contents in string data type</returns>
        public string get()
        {
            string OUTPUT = "";

            for (int i = 0; i < RAM_SIZE; i++)
                for (int j = 0; j < RAM_CONTENT; j++)
                    if (memory[i, j] == null)
                        memory[i, j] = "11111111";

            for (int i = 0; i < RAM_SIZE; i++)
            {
                OUTPUT += memory[i, 0] + memory[i, 1] + "\n";
            }

            return OUTPUT;
        }

    }

}
