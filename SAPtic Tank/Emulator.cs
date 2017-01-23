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
    class Emulator
    {
        //program counter
        static int COUNTER = 0;
        //MAR
        static int MAR = 0;
        //ROM
        static string[] ROM = new string[16];
        static string ROM_DATA = "";
        //Instruction Register
        static string IR = "";
        //Accumulator
        static int ACC = 0;
        //Add/Subtract Register
        static int AS;
        //BRegister
        static int BREG = 0;
        //Output Register
        static string OUT = "";

        //command
        static int CONTROLLER = 0;

        public Emulator() {
            ROM = read().Split();

            while (true)
            {
                //t1
                MAR = COUNTER;

                //t2
                COUNTER++;

                //t3
                ROM_DATA = ROM[MAR].Substring(5, 8);
                IR = ROM_DATA;

                //t4
                string UPPER_NIBBLE = IR.Substring(0, 4);
                string LOWER_NIBBLE = IR.Substring(4, 4);

                CONTROLLER = Convert.ToInt32(UPPER_NIBBLE, 2);
                MAR = Convert.ToInt32(LOWER_NIBBLE, 2);

                if (CONTROLLER == 0)
                {
                    //LDA

                    //t5
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    ACC = Convert.ToInt32(ROM_DATA, 2);
                    
                }
                else if(CONTROLLER == 1)
                {
                    //ADD

                    //t5
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    BREG = Convert.ToInt32(ROM[MAR].Substring(5, 8), 2);

                    // t6
                    AS = ACC + BREG;
                    ACC = AS;
                }
                else if (CONTROLLER == 2)
                {
                    //SUBTRACT

                    //t5
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    BREG = Convert.ToInt32(ROM[MAR].Substring(5, 8), 2);

                    //t6
                    AS = ACC - BREG;
                    ACC = AS;
                }
                else if(CONTROLLER == 14)
                {
                    //OUT

                    //t5
                    OUT += AS;
                    Console.WriteLine(OUT);
                    Console.ReadKey();
                }
                else if(CONTROLLER == 15)
                {
                    //HLT

                    //t4
                    break;
                }
                else
                {
                    OUT += ACC;
                    Console.WriteLine(OUT);
                    break;
                }
            }
        }
        private string read()
        {
            string BIN_DATA = "";
            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Title = "SAPtic Tank - Open File";
            open_file.Filter = "SAP1 Files (*.bin)|*.bin";

            DialogResult result = open_file.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = open_file.FileName;

                try
                {
                    BIN_DATA = File.ReadAllText(file);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show("Cannot open File 😐");
                }
            }

            return BIN_DATA;
        }
    }
}
