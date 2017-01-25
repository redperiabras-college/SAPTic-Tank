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
        Command LDA = new Command();
        Command ADD = new Command();
        Command SUB = new Command();
        Command OUT = new Command();
        Command HLT = new Command();

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
        static string OUT1 = "";

        //command
        static int CONTROLLER = 0;

        public Emulator() {
            Object t1LDA = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2LDA = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3LDA = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4LDA = Properties.Resources.ResourceManager.GetObject("state4LDA");
            Object t5LDA = Properties.Resources.ResourceManager.GetObject("state5LDA");
            Object t6LDA = Properties.Resources.ResourceManager.GetObject("state4HLT");
            LDA.t1.image = t1LDA as Image;
            LDA.t2.image = t2LDA as Image;
            LDA.t3.image = t3LDA as Image;
            LDA.t4.image = t4LDA as Image;
            LDA.t5.image = t5LDA as Image;
            LDA.t6.image = t6LDA as Image;

            Object t1ADD = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2ADD = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3ADD = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4ADD = Properties.Resources.ResourceManager.GetObject("state4ADDSUB");
            Object t5ADD = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6ADD = Properties.Resources.ResourceManager.GetObject("state4HLT");
            ADD.t1.image = t1ADD as Image;
            ADD.t2.image = t2ADD as Image;
            ADD.t3.image = t3ADD as Image;
            ADD.t4.image = t4ADD as Image;
            ADD.t5.image = t5ADD as Image;
            ADD.t6.image = t6ADD as Image;

            Object t1SUB = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2SUB = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3SUB = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4SUB = Properties.Resources.ResourceManager.GetObject("state4ADDSUB");
            Object t5SUB = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6SUB = Properties.Resources.ResourceManager.GetObject("state4HLT");
            SUB.t1.image = t1SUB as Image;
            SUB.t2.image = t2SUB as Image;
            SUB.t3.image = t3SUB as Image;
            SUB.t4.image = t4SUB as Image;
            SUB.t5.image = t5SUB as Image;
            SUB.t6.image = t6SUB as Image;

            Object t1OUT = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2OUT = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3OUT = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4OUT = Properties.Resources.ResourceManager.GetObject("state4OUT");
            Object t5OUT = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6OUT = Properties.Resources.ResourceManager.GetObject("state4HLT");
            OUT.t1.image = t1OUT as Image;
            OUT.t2.image = t2OUT as Image;
            OUT.t3.image = t3OUT as Image;
            OUT.t4.image = t4OUT as Image;
            OUT.t5.image = t5OUT as Image;
            OUT.t6.image = t6OUT as Image;

            Object t1HLT = Properties.Resources.ResourceManager.GetObject("state1");
            Object t2HLT = Properties.Resources.ResourceManager.GetObject("state2");
            Object t3HLT = Properties.Resources.ResourceManager.GetObject("state3");
            Object t4HLT = Properties.Resources.ResourceManager.GetObject("state4HLT");
            Object t5HLT = Properties.Resources.ResourceManager.GetObject("state5ADDSUB");
            Object t6HLT = Properties.Resources.ResourceManager.GetObject("state4HLT");
            HLT.t1.image = t1HLT as Image;
            HLT.t2.image = t2HLT as Image;
            HLT.t3.image = t3HLT as Image;
            HLT.t4.image = t4HLT as Image;
            HLT.t5.image = t5HLT as Image;
            HLT.t6.image = t6HLT as Image;


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
                    OUT1 += AS;
                    Console.WriteLine(OUT1);
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
                    OUT1 += ACC;
                    Console.WriteLine(OUT1);
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

        class Command
    {
        public Timeslot t1 = new Timeslot();
        public Timeslot t2 = new Timeslot();
        public Timeslot t3 = new Timeslot();
        public Timeslot t4 = new Timeslot();
        public Timeslot t5 = new Timeslot();
        public Timeslot t6 = new Timeslot();
    }
        class Timeslot
    {
        public Image image;
        
    }
}
