using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Linq.Enumerable;
using System.Text.RegularExpressions;
using System.Drawing;

namespace SAPtic_Tank
{
    class Emulator
    {
        public string mchnCode;
        public string assmblyCode;

        Command LDA = new Command();
        Command ADD = new Command();
        Command SUB = new Command();
        Command OUT = new Command();
        Command HLT = new Command();

        private int jogTimeSlot = 0;
        string UPPER_NIBBLE ="";
        string LOWER_NIBBLE = "";

        //program counter - binary
        static int COUNTER = 0;
        //MAR - binary
        static int MAR = 0;
        //ROM
        static string[] ROM = new string[16];
        static string ROM_DATA = "";
        //Instruction Register - Mnemonics
        static string IR = "";
        //Accumulator - Hex
        static int ACC = 0;
        //Add/Subtract Register
        static int AS;
        //BRegister - Hex
        static int BREG = 0;
        //Output Register - Hex
        static int OUT1;

        //command - 12 bit binary
        static int CONTROLLER = 0;

        public Emulator(string input) {
            Object t1LDA = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2LDA = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3LDA = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4LDA = Properties.Resources.ResourceManager.GetObject("state4LDA");
            Object t5LDA = Properties.Resources.ResourceManager.GetObject("state5LDA");
            Object t6LDA = Properties.Resources.ResourceManager.GetObject("state4HLT");
            LDA.t1 = t1LDA as Image;
            LDA.t2 = t2LDA as Image;
            LDA.t3 = t3LDA as Image;
            LDA.t4 = t4LDA as Image;
            LDA.t5 = t5LDA as Image;
            LDA.t6 = t6LDA as Image;

            Object t1ADD = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2ADD = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3ADD = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4ADD = Properties.Resources.ResourceManager.GetObject("state4ADDSUB");
            Object t5ADD = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6ADD = Properties.Resources.ResourceManager.GetObject("state4HLT");
            ADD.t1 = t1ADD as Image;
            ADD.t2 = t2ADD as Image;
            ADD.t3 = t3ADD as Image;
            ADD.t4 = t4ADD as Image;
            ADD.t5 = t5ADD as Image;
            ADD.t6 = t6ADD as Image;

            Object t1SUB = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2SUB = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3SUB = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4SUB = Properties.Resources.ResourceManager.GetObject("state4ADDSUB");
            Object t5SUB = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6SUB = Properties.Resources.ResourceManager.GetObject("state4HLT");
            SUB.t1 = t1SUB as Image;
            SUB.t2 = t2SUB as Image;
            SUB.t3 = t3SUB as Image;
            SUB.t4 = t4SUB as Image;
            SUB.t5 = t5SUB as Image;
            SUB.t6 = t6SUB as Image;

            Object t1OUT = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2OUT = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3OUT = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4OUT = Properties.Resources.ResourceManager.GetObject("state4OUT");
            Object t5OUT = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6OUT = Properties.Resources.ResourceManager.GetObject("state4HLT");
            OUT.t1 = t1OUT as Image;
            OUT.t2 = t2OUT as Image;
            OUT.t3 = t3OUT as Image;
            OUT.t4 = t4OUT as Image;
            OUT.t5 = t5OUT as Image;
            OUT.t6 = t6OUT as Image;

            Object t1HLT = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2HLT = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3HLT = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4HLT = Properties.Resources.ResourceManager.GetObject("state4HLT");
            Object t5HLT = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6HLT = Properties.Resources.ResourceManager.GetObject("state4HLT");
            HLT.t1 = t1HLT as Image;
            HLT.t2 = t2HLT as Image;
            HLT.t3 = t3HLT as Image;
            HLT.t4 = t4HLT as Image;
            HLT.t5 = t5HLT as Image;
            HLT.t6 = t6HLT as Image;

            ROM = input.Split('\n');
            
        }

        public void generateCodes()
        {
            // generating machine code
            bool loopCtrl = false;
            bool halted = false;
            for (int x = 0; x < ROM.Length - 1; x++)
            {
                string normalizedData = ROM[x].Substring(5, 8);
                string line = x.ToString("X");

                if (loopCtrl)
                    if (!normalizedData.Equals("11111111"))
                        loopCtrl = false;
                    else
                        mchnCode += line.PadLeft(2, '0') + "H ---\n";
                else if (normalizedData.Equals("11111111") && halted)
                {
                    mchnCode += line.PadLeft(2, '0') + "H ---\n";
                }
                else if (normalizedData.Equals("11111111"))
                {
                    loopCtrl = true;
                    halted = true;
                    string code = Convert.ToInt32(normalizedData.Substring(0, 4), 2).ToString("X");
                    mchnCode += line.PadLeft(2, '0') + "H " + code + "xH\n";
                }
                else if (normalizedData.Equals("11101111"))
                {
                    string code = Convert.ToInt32(normalizedData.Substring(0, 4), 2).ToString("X");
                    mchnCode += line.PadLeft(2, '0') + "H " + code + "xH\n";
                }
                else
                {
                    string code = Convert.ToInt32(normalizedData, 2).ToString("X");
                    mchnCode += line.PadLeft(2, '0') + "H " + code.PadLeft(2, '0') + "H\n";
                }
            }

            //generating assembly code

            string orgCommand = "";
            string orgMain = "";
            for (int x = 0; x < ROM.Length-1; x++)
            {
                string upper_bin = ROM[x].Substring(5, 4);
                string lower_bin = ROM[x].Substring(9, 4);

                int refAddress = Convert.ToInt32(lower_bin, 2);
                string data_bin = ROM[refAddress].Substring(5, 8);

                bool outerCtrl = false;

                switch (upper_bin)
                {
                    case "0000":
                        {
                            orgMain += "ORG " + x.ToString("X").PadLeft(2, '0') + "H, " + "MAIN\n\nMAIN:\n";
                            assmblyCode += "LDA " + refAddress.ToString("X").PadLeft(2, '0') + "H\n";
                            orgCommand += "ORG " + Convert.ToInt32(lower_bin, 2).ToString("X").PadLeft(2, '0') + "H, "+ Convert.ToInt32(data_bin, 2).ToString("X").PadLeft(2, '0') + "H \n";
                            break;
                        }
                    case "0001":
                        {
                            assmblyCode += "ADD " + refAddress.ToString("X").PadLeft(2, '0') + "H\n";
                            orgCommand += "ORG " + Convert.ToInt32(lower_bin, 2).ToString("X").PadLeft(2, '0') + "H, " + Convert.ToInt32(data_bin, 2).ToString("X").PadLeft(2, '0') + "H \n";
                            break;
                        }
                    case "0010":
                        {
                            assmblyCode += "SUB " + refAddress.ToString("X").PadLeft(2, '0') + "H\n";
                            orgCommand += "ORG " + Convert.ToInt32(lower_bin, 2).ToString("X").PadLeft(2, '0') + "H, " + Convert.ToInt32(data_bin, 2).ToString("X").PadLeft(2, '0') + "H\n";
                            break;
                        }
                    case "1110":
                        {
                            assmblyCode += "OUT\n";
                            break;
                        }
                    case "1111":
                        {
                            outerCtrl = true;
                            assmblyCode += "HLT";
                            assmblyCode = orgCommand + orgMain + assmblyCode;
                            break;
                        }
                        
                }

                if (outerCtrl)
                    break;
            }
        }

        public async void continous(MainFrame frame, int delay)
        {
            while (true)
            {
                //t1
                MAR = COUNTER;
                frame.update(1, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "010111100011", ADD.t1);
                await Task.Delay(delay);

                //t2
                COUNTER++;
                frame.update(2, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "101111100011", ADD.t2);
                await Task.Delay(delay);

                //t3
                ROM_DATA = ROM[MAR].Substring(5, 8);
                IR = ROM_DATA;
                frame.update(3, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001001100011", ADD.t3);
                await Task.Delay(delay);

                //t4
                string UPPER_NIBBLE = IR.Substring(0, 4);
                string LOWER_NIBBLE = IR.Substring(4, 4);
                CONTROLLER = Convert.ToInt32(UPPER_NIBBLE, 2);

                MAR = Convert.ToInt32(LOWER_NIBBLE, 2);

                if (CONTROLLER == 0)
                {
                    //LDA

                    //t4
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "000110100011", LDA.t4);
                    await Task.Delay(delay);

                    //t5
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    ACC = Convert.ToInt32(ROM_DATA, 2);
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011000011", LDA.t5);
                    await Task.Delay(delay);

                    //t6
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011000011", LDA.t6);
                    await Task.Delay(delay);
                }
                else if (CONTROLLER == 1)
                {
                    //ADD

                    //t4
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "000110100011", ADD.t4);
                    await Task.Delay(delay);

                    //t5
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    BREG = Convert.ToInt32(ROM[MAR].Substring(5, 8), 2);
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011100001", ADD.t5);
                    await Task.Delay(delay);

                    // t6
                    AS = ACC + BREG;
                    ACC = AS;
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111000111", ADD.t6);
                    await Task.Delay(delay);
                }
                else if (CONTROLLER == 2)
                {
                    //SUBTRACT

                    //t4
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "000110100011", SUB.t4);
                    await Task.Delay(delay);

                    //t5
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    BREG = Convert.ToInt32(ROM[MAR].Substring(5, 8), 2);
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011100001", SUB.t5);
                    await Task.Delay(delay);

                    //t6
                    AS = ACC - BREG;
                    ACC = AS;
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111001111", SUB.t6);
                    await Task.Delay(delay);
                }
                else if (CONTROLLER == 14)
                {
                    //OUT
                    OUT1 = ACC;
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111110010", OUT.t4);
                    await Task.Delay(delay);

                    //t5
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111110010", OUT.t5);
                    await Task.Delay(delay);

                    //t6
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111110010", OUT.t6);
                    await Task.Delay(delay);
                }
                else if (CONTROLLER == 15)
                {
                    //HLT

                    //t4
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111100011", HLT.t4);
                    await Task.Delay(delay);

                    //t5
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111100011", HLT.t5);
                    await Task.Delay(delay);

                    //t6
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111100011", HLT.t6);
                    await Task.Delay(delay);

                    break;
                }
            }

            //reset registers
            COUNTER = 0;
            MAR = 0;
            ROM_DATA = "";
            IR = "";
            ACC = 0;
            BREG = 0;
            OUT1 = 0;
            CONTROLLER = 5;
            frame.enableControlButtons();
        }

        public async void jog(MainFrame frame)
        {
            jogTimeSlot++;
            if (jogTimeSlot == 1)
            {
                //t1
                MAR = COUNTER;
                frame.update(1, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "010111100011", LDA.t1);
            }  
            else if(jogTimeSlot == 2)
            {
                //t2
                COUNTER++;
                frame.update(2, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "101111100011", LDA.t2);
            }
            else if(jogTimeSlot == 3)
            {
                ROM_DATA = ROM[MAR].Substring(5, 8);
                IR = ROM_DATA;
                frame.update(3, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001001100011", LDA.t3);

                //t4
                UPPER_NIBBLE = IR.Substring(0, 4);
                LOWER_NIBBLE = IR.Substring(4, 4);
                CONTROLLER = Convert.ToInt32(UPPER_NIBBLE, 2);
                MAR = Convert.ToInt32(LOWER_NIBBLE, 2);
            }


            if(CONTROLLER == 0)
            {
                if (jogTimeSlot == 4)
                {

                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "000110100011", LDA.t4);
                }
                else if (jogTimeSlot == 5)
                {
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    ACC = Convert.ToInt32(ROM_DATA, 2);
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011000011", LDA.t5);
                }
                else if (jogTimeSlot == 6)
                {
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011000011", LDA.t6);
                    jogTimeSlot = 0;
                }
            }
            else if(CONTROLLER == 1)
            {
                if (jogTimeSlot == 4)
                {
                    //t4
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "000110100011", ADD.t4);
                }
                else if (jogTimeSlot == 5)
                {
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    BREG = Convert.ToInt32(ROM[MAR].Substring(5, 8), 2);
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011100001", ADD.t5);
                }
                else if (jogTimeSlot == 6)
                {
                    AS = ACC + BREG;
                    ACC = AS;
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111000111", ADD.t6);
                    jogTimeSlot = 0;
                }
            }
            else if(CONTROLLER == 2)
            {
                if (jogTimeSlot == 4)
                {
                    //t4
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "000110100011", SUB.t4);
                }
                else if (jogTimeSlot == 5)
                {
                    ROM_DATA = ROM[MAR].Substring(5, 8);
                    BREG = Convert.ToInt32(ROM[MAR].Substring(5, 8), 2);
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001011100001", SUB.t5);
                }
                else if (jogTimeSlot == 6)
                {
                    AS = ACC - BREG;
                    ACC = AS;
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111001111", SUB.t6);
                    jogTimeSlot = 0;
                }
            }
            else if(CONTROLLER == 14)
            {
                if (jogTimeSlot == 4)
                {
                    //OUT
                    OUT1 = ACC;
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111110010", OUT.t4);
                }
                else if (jogTimeSlot == 5)
                {
                    //t5
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111110010", OUT.t5);
                }
                else if (jogTimeSlot == 6)
                {
                    //t6
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111110010", OUT.t5);
                    jogTimeSlot = 0;
                }
            }
            else if(CONTROLLER == 15)
            {
                if (jogTimeSlot == 4)
                {
                    //t4
                    frame.update(4, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111100011", HLT.t4);
                }
                else if (jogTimeSlot == 5)
                {
                    //t5
                    frame.update(5, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111100011", HLT.t5);
                }
                else if (jogTimeSlot == 6)
                {
                    //t6
                    frame.update(6, COUNTER, MAR, CONTROLLER, ACC, BREG, OUT1, "001111100011", HLT.t6);
                    //reset registers
                    jogTimeSlot = 0;
                    COUNTER = 0;
                    MAR = 0;
                    ROM_DATA = "";
                    IR = "";
                    ACC = 0;
                    BREG = 0;
                    OUT1 = 0;
                    CONTROLLER = 5;
                    frame.disableJog();
                    await Task.Delay(3000);
                    frame.enableControlButtons();
                }

                
            }
                        
            
            }
        }

    class Command
    {
        public Image t1;
        public Image t2;
        public Image t3;
        public Image t4;
        public Image t5;
        public Image t6;
    }
    
}
