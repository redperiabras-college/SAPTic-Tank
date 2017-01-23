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
        static ProgramCounter pc = new ProgramCounter();
        static MAR mar = new MAR(pc);
        static RAM ram = new RAM(mar);
        static IR ir = new IR(ram, mar);
        static Accumulator acc = new Accumulator(ram);
        static BRegister breg = new BRegister(ram);
        AS ad_su = new AS(acc, breg);
        OutputRegister or = new OutputRegister(acc);

        public Emulator() {
            OpenFileDialog open_file = new OpenFileDialog();
            open_file.Title = "SAPtic Tank - Open File";
            open_file.Filter = "SAP1 Files (*.bin)|*.bin";
            
            DialogResult result = open_file.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = open_file.FileName;

                try
                {
                    Console.WriteLine(file);
                    ram.setValue(file);
                    start();
                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    MessageBox.Show("Cannot open File 😐");
                }
            }
        }

        private void start()
        {
            //t1
            mar._LM();
            pc.CP();
            pc.EP();

            Console.WriteLine("" + pc.getCP() + pc.getEP() + mar.get_LM() + ram.get_CE() + ir.get_LI() + ir.get_EI() + acc.get_LA() + acc.get_EA() + ad_su.getSU() + ad_su.getEU() + breg.get_LB() + or.get_LO());
        }
    }

    class Controller
    {

        public Controller()
        {

        }
        
    }

    class ProgramCounter
    {
        private int COUNTER;

        private int SWITCH_CP;
        private int SWITCH_EP;

        public ProgramCounter()
        {
            COUNTER = 0;

            //active high
            SWITCH_EP = 0;
            SWITCH_CP = 0;
        }

        public void CP()
        {
            if (SWITCH_CP == 0)
                SWITCH_CP = 1;
            else
                SWITCH_CP = 0;

            check_counter();
        }

        public void EP()
        {
            if (SWITCH_CP == 0)
                SWITCH_CP = 1;
            else
                SWITCH_CP = 0;

            check_counter();
        }

        private void check_counter()
        {
            //increment state
            if ((SWITCH_CP == 1) && (SWITCH_EP == 0))
                COUNTER++;
        }

        public int getCounter() {
            return COUNTER;
        }

        public int getEP()
        {
            return SWITCH_EP;
        }

        public int getCP()
        {
            return SWITCH_CP;
        }
    }

    class MAR
    {
        ProgramCounter pc;

        private int MEMORY_ADDRESS;

        private int SWITCH_LM;

        public MAR(ProgramCounter pc)
        {
            this.pc = pc;

            MEMORY_ADDRESS = 0;

            //active low
            SWITCH_LM = 1;
        }

        public void _LM()
        {
            if (SWITCH_LM == 1)
                SWITCH_LM = 0;
            else
            {
                setAddress();
                SWITCH_LM = 1;
            }
        }

        public int get_LM()
        {
            return SWITCH_LM;
        }

        public void setMAR(int MEMORY_ADDRESS)
        {
            this.MEMORY_ADDRESS = MEMORY_ADDRESS;
        }

        private void setAddress()
        {
            //sets memory address from pc if CP is 1 and EP is 0
            if ((pc.getCP() == 1) && (pc.getEP() == 0) && (SWITCH_LM == 0))
                this.MEMORY_ADDRESS = pc.getCounter();
        }

        public void setAddress(int address)
        {
            this.MEMORY_ADDRESS = address;
        }

        public int getAddress()
        {
            return MEMORY_ADDRESS;
        }
    }

    class RAM
    {
        MAR mar;

        private int RAM_SIZE;
        private string[] READ_ONLY_MEMORY;
        private string DATA;

        private int SWITCH_CE;

        public RAM(MAR mar)
        {
            this.mar = mar;

            RAM_SIZE = 16;
            READ_ONLY_MEMORY = new string[16];
            DATA = "";

            //active low
            SWITCH_CE = 1;
        }

        public void _CE()
        {
            if (SWITCH_CE == 1)
            {
                SWITCH_CE = 0;
                setData(mar.getAddress());
            }
            else
                SWITCH_CE = 1;
                
        }

        public int get_CE()
        {
            return SWITCH_CE;
        }

        public void setValue(string assembly)
        {
            string[] lines = assembly.Split();
            for (int x = 0; x < lines.Length; x++)
            {
                READ_ONLY_MEMORY[x] = lines[x].Substring(6, 13);
            }
        }

        private void setData(int address)
        {
            DATA = READ_ONLY_MEMORY[address];
        }

        public string getData()
        {
            return DATA;
        }
    }

    class IR
    {
        RAM ram;
        MAR mar;

        private string INSTRUCTION;
        private int UPPER_NIBBLE;
        private int LOWER_NIBBLE;

        private int SWITCH_LI = 1;
        private int SWITCH_EI = 1;

        public IR(RAM ram, MAR mar)
        {
            this.ram = ram;
            this.mar = mar;

            INSTRUCTION = "";
            UPPER_NIBBLE = 0;
            LOWER_NIBBLE = 0;

            SWITCH_LI = 1;
            SWITCH_EI = 1;
        }

        public void _LI()
        {
            if (SWITCH_LI == 1)
                SWITCH_LI = 0;
            else
                SWITCH_LI = 1;

            check_ir();
        }

        public int get_LI()
        {
            return SWITCH_LI;
        }

        public void _EI()
        {
            if (SWITCH_EI == 1)
                SWITCH_EI = 0;
            else
                SWITCH_EI = 1;

            check_ir();
        }

        public int get_EI()
        {
            return SWITCH_EI;
        }

        private void check_ir()
        {
            if ((SWITCH_LI == 0) && (SWITCH_EI == 1))
                setInstruction();
            //sets MAR from IR
            else if ((get_LI() == 1) && (get_EI() == 0) && (mar.get_LM() == 0))
                mar.setAddress(getLower());
        }

        private void setInstruction()
        {
            this.INSTRUCTION = ram.getData();
            this.UPPER_NIBBLE = Convert.ToInt32(INSTRUCTION.Substring(0, 4),2);
            this.LOWER_NIBBLE = Convert.ToInt32(INSTRUCTION.Substring(4, 8), 2);
        }

        private int getLower()
        {
            return LOWER_NIBBLE;
        }
    }
    
    class Accumulator
    {
        RAM ram;

        private int value;

        private int SWITCH_LA;
        private int SWITCH_EA;

        public Accumulator(RAM ram)
        {
            this.ram = ram;

            value = 0;

            SWITCH_LA = 1;
            SWITCH_EA = 0;
        }

        public void _LA()
        {
            if (SWITCH_LA == 1)
                SWITCH_LA = 0;
            else
                SWITCH_LA = 1;
        }

        public int get_LA()
        {
            return SWITCH_LA;
        }

        public int get_EA()
        {
            return SWITCH_EA;
        }

        public void EA()
        {
            if (SWITCH_EA == 0)
                SWITCH_EA = 1;
            else
                SWITCH_EA = 0;
        }

        private void check_acc()
        {
            //get value from RAM
            if ((SWITCH_LA == 0) && (SWITCH_EA == 0) && (ram.get_CE() == 0))
            {
                int RAM_VALUE = Convert.ToInt32(ram.getData(), 2);
                this.value = RAM_VALUE;
            }
        }

        public void setValue(int value)
        {
            this.value = value;
        }

        public int getValue()
        {
            return this.value;
        }
    }

    class AS
    {
        Accumulator acc;
        BRegister breg;

        /// <summary>
        /// 0 for add
        /// 1 for subtract
        /// </summary>
        private int operation;
        private int value;

        private int SWITCH_SU;
        private int SWITCH_EU;

        public AS(Accumulator acc, BRegister breg)
        {
            this.acc = acc;
            this.breg = breg;

            operation = 0;

            SWITCH_SU = 0;
            SWITCH_EU = 0;
        }

        public void SU()
        {
            if (SWITCH_SU == 0)
                SWITCH_SU = 1;
            else
                SWITCH_SU = 0;

            check_operation();
        }

        public int getSU()
        {
            return SWITCH_SU;
        }

        public void EU()
        {
            if (SWITCH_EU == 0)
                SWITCH_EU = 1;
            else
                SWITCH_EU = 0;

            check_operation();
        }

        public int getEU()
        {
            return SWITCH_EU;
        }

        private void check_operation()
        {
            if ((SWITCH_SU == 0) && (SWITCH_EU == 1))
            {
                value = acc.getValue() + breg.getValue();
                acc.setValue(value);
            }
            else if ((SWITCH_SU == 1) && (SWITCH_EU == 1))
            {
                value = acc.getValue() - breg.getValue();
                acc.setValue(value);
            }
        }

    }
    
    class BRegister
    {
        RAM ram;

        private int value;

        private int SWITCH_LB;
         
        public BRegister(RAM ram)
        {
            this.ram = ram;

            value = 0;

            //active low
            SWITCH_LB = 1;
        }

        public void _LB()
        {
            if (SWITCH_LB == 1)
                SWITCH_LB = 0;
            else
            {
                setValue();
                SWITCH_LB = 1;
            }
                
        }
       
        public int get_LB()
        {
            return SWITCH_LB;
        }

        private void setValue()
        {
            string RAM_DATA = ram.getData();
            int RAM_VALUE = Convert.ToInt32(RAM_DATA, 2);
            this.value = RAM_VALUE;
        }

        public int getValue()
        {
            return this.value;
        }
    }

    class OutputRegister
    {
        Accumulator acc;

        private int SWITCH_LO;

        public OutputRegister(Accumulator acc)
        {
            this.acc = acc;

            SWITCH_LO = 1;
        }

        public void _LO()
        {
            if (SWITCH_LO == 1)
                SWITCH_LO = 0;
            else
            {
                Console.WriteLine("Output: " + acc.getValue());
                SWITCH_LO = 1;
            }
        }

        public int get_LO()
        {
            return SWITCH_LO;
        }
    }
}
