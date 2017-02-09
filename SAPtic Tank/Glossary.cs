using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPtic_Tank
{
    public partial class Glossary: MetroForm
    {
        public Glossary()
        {
            InitializeComponent();
        }

        private void Glossary_Load(object sender, EventArgs e)
        {

        }

        private void terms_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (terms.SelectedIndex)
            {
                case 0:
                    definition.Text = "A buffer register that stores immediate answers during a computer runs. It has two outputs, one directly goes to the adder/subtractor, and the other is to the W-Bus. Therefore 8-bit accumulator word continuously drives the Adder/Subtractor; the same word appears on the W-Bus when EA is high.";
                    break;
                case 1:
                    definition.Text = "The Adder/Subtractor is synchronous. This means that its contents can change as soon as the input word change. When EU is High, these contents appears on the W BUS.";
                    break;
                case 2:
                    definition.Text = "It is used in Arithmetic operation. A Low 𝑳𝑩 and a positive edge clock load the word on the W-Bus into the BRegister.";
                    break;
                case 3:
                    definition.Text = "It is a row of 8 LED. Because each LED connects to one flip flop of the output port, the binary display shows us the contents of the output port. Therefore, after we’ve transferred an answer from the accumulator to the output port, we can see the answer in Binary form.";
                    break;
                case 4:
                    definition.Text = "The lower left block contains the Controller Sequencer Unit. This resets the program counter to 0000 and wipes out the last instruction in the Instruction Register.";
                    break;
                case 5:
                    definition.Text = "Fetch cycle is the first part of the instruction cycle. During the fetch cycle, the address is sent to the memory, the program counter is incremented, and the instruction is transferred from the memory to the instruction register.";
                    break;
                case 6:
                    definition.Text = "It includes the address and data switch registers. These switch registers which are part of the input unit, allow you to send 4bit-address and 8-bit data to the RAM. ";
                    break;
                case 7:
                    definition.Text = "To fetch an instruction from the memory, the computer does a memory read operation. This places the contents of the addressed memory location on a W-bus. At the same time, the IR is setup for loading the next positive edge clock.";
                    break;
                case 8:
                    definition.Text = "At the end of a computer runs, the accumulator contains to the problem being solved. At this point, we need to transfer the answer to the outside world. This is where the OR is used. When EA is high and 𝑳𝑶 ̅̅̅̅ is low, the next positive clock edge loads the (A) word into the output register. ";
                    break;
                case 9:
                    definition.Text = "The Program is stored at the beginning of the memory of the first instruction of binary Address 0000, the second instruction is at 0001 and so on. The Program Counter, which is a part of the Control Unit counts from 0000-1111. Its job is to send to the memory the address of the next instruction to be fetched and executed. ";
                    break;
                case 10:
                    definition.Text = "The RAM is a 16 x 8 static TTL RAM. The RAM can be programmed by means of the address and data switch registers.  This allows you to store program and data in the memory before a computer runs. ";
                    break;
            }
        }
    }
}
