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
    public partial class MainFrame : MetroForm
    {
        File assembler_file = new File();
        File emulator_file = new File();

        Assembler ass;
        Emulator emu;

        public bool Mode = false;

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroTabControl2.SelectedTab = metroTabPage1;
            assemblebin.Enabled = true;
            saveAs.Enabled = true;
            inputText.Enabled = true;
            inputText.Focus();
            assemblerButton.Enabled = true;
            inputText.Text = assembler_file.assemblerReader();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currTime = DateTime.Now.ToString();
            log.Text += currTime + "\n" + assembler_file.save(inputText.Text) + "\n\n";
        }

        private void logContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            log.Text = "";
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currTime = DateTime.Now.ToString();
            string status = assembler_file.saveAs(inputText.Text);
            if(!status.Equals(""))
                log.Text += currTime + "\n" + status + "\n\n";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async void metroTile1_Click(object sender, EventArgs e)
        {
            assemblingProgress.UseWaitCursor = true;
            assemblingProgress.Spinning = true;
            assemblingProgress.Show();
            this.Cursor = Cursors.AppStarting;

            string logText = "";
            try
            {
                ass = new Assembler();
                string output = ass.assemble(inputText.Text);
                assembler_file.export(output);
                
                logText = "Assembling Complete.";
            }
            catch (Exception d)
            {
                logText = d.Message;
            }

            await Task.Delay(1000);

            string currTime = DateTime.Now.ToString();
            log.Text += currTime + "\n" + logText + "\n\n";

            assemblingProgress.UseWaitCursor = false;
            assemblingProgress.Spinning = false;
            this.Cursor = Cursors.Default;
            assemblingProgress.Hide();

            log.Select(log.Text.Length - 1, 0);
            log.ScrollToCaret();
        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroTabControl2.SelectedTab = metroTabPage1;
            assemblebin.Enabled = true;
            saveAs.Enabled = false;
            if (!inputText.Text.Equals(""))
                inputText.Text = "";
            assembler_file.clear();
            inputText.Enabled = true;
            inputText.Focus();
            assemblerButton.Enabled = true;
        }

        private void assembleCreateBinFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroTile1_Click(sender, e);
        }

        private void loadBinFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            metroTabControl2.SelectedTab = metroTabPage2;
            string data = emulator_file.emulatorReader();

            emu = new Emulator(data);
            emu.generateCodes();
            machineCode.Lines = emu.mchnCode.Split('\n');
            assemblyCode.Lines = emu.assmblyCode.Split('\n');
            btn_jog.Enabled = true;
            btn_continuous.Enabled = true;
            this.timeSlot.Text = "Time Slot: 0";
            this.txtBox_pcounter.Text = "0000";
            this.txtBox_pcounter.Text = "";
            this.txtBox_MAR.Text = "";
            this.txtBox_Acc.Text = "";
            this.txtBox_IR.Text = "";
            this.txtBox_bReg.Text = "";
            this.txtBox_outReg.Text = "";
            this.txtBox_ctrSeq.Text = "";

            pictureBox1.Image = Properties.Resources.off1;
            pictureBox2.Image = Properties.Resources.off1;
            pictureBox3.Image = Properties.Resources.off1;
            pictureBox4.Image = Properties.Resources.off1;
            pictureBox5.Image = Properties.Resources.off1;
            pictureBox6.Image = Properties.Resources.off1;
            pictureBox7.Image = Properties.Resources.off1;
            pictureBox8.Image = Properties.Resources.off1;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void btn_continuous_Click(object sender, EventArgs e)
        {
            btn_continuous.Enabled = false;
            btn_jog.Enabled = false;
            this.timeSlot.Text = "Time Slot: ";
            this.txtBox_pcounter.Text = "";
            this.txtBox_MAR.Text = "";
            this.txtBox_Acc.Text = "";
            this.txtBox_IR.Text = "";
            this.txtBox_bReg.Text = "";
            this.txtBox_outReg.Text = "";
            this.txtBox_ctrSeq.Text = "";
            pictureBox1.Image = Properties.Resources.off1;
            pictureBox2.Image = Properties.Resources.off1;
            pictureBox3.Image = Properties.Resources.off1;
            pictureBox4.Image = Properties.Resources.off1;
            pictureBox5.Image = Properties.Resources.off1;
            pictureBox6.Image = Properties.Resources.off1;
            pictureBox7.Image = Properties.Resources.off1;
            pictureBox8.Image = Properties.Resources.off1;
            emu.continous(this, 1000);
        }

        public void enableControlButtons()
        {
            btn_continuous.Enabled = true;
            btn_jog.Enabled = true;
        }

        public void update(
            int ts,
            int pc,
            int mar,
            int inst,
            int acc,
            int breg,
            int output,
            string ctrlr,
            Image img
            )
        {
            this.timeSlot.Text = "Time Slot: "+ts;
            this.txtBox_pcounter.Text = Convert.ToString(pc, 2).PadLeft(4,'0');
            this.txtBox_MAR.Text = Convert.ToString(mar, 2).PadLeft(4, '0');
            this.txtBox_Acc.Text = acc.ToString("X").PadLeft(2, '0') + "H";

            if(inst!=5)
                switch (inst)
                {
                    case 0:
                        this.txtBox_IR.Text = "LDA";
                        break;
                    case 1:
                        this.txtBox_IR.Text = "ADD";
                        break;
                    case 2:
                        this.txtBox_IR.Text = "SUB";
                        break;
                    case 14:
                        this.txtBox_IR.Text = "OUT";
                        break;
                    case 15:
                        this.txtBox_IR.Text = "HLT";
                        break;
                }

            if(breg!=0)
                this.txtBox_bReg.Text = breg.ToString("X").PadLeft(2,'0')+"H";
            if (output != 0)
                this.txtBox_outReg.Text = output.ToString("X").PadLeft(2, '0') + "H";
            if (output != 0)
            {
                string output_bin = Convert.ToString(output, 2).PadLeft(8, '0');
                if (output_bin[0].Equals('1'))
                    pictureBox1.Image = Properties.Resources.on1;
                else
                    pictureBox1.Image = Properties.Resources.off1;

                if (output_bin[1].Equals('1'))
                    pictureBox2.Image = Properties.Resources.on1;
                else
                    pictureBox2.Image = Properties.Resources.off1;

                if (output_bin[2].Equals('1'))
                    pictureBox3.Image = Properties.Resources.on1;
                else
                    pictureBox3.Image = Properties.Resources.off1;

                if (output_bin[3].Equals('1'))
                    pictureBox4.Image = Properties.Resources.on1;
                else
                    pictureBox4.Image = Properties.Resources.off1;

                if (output_bin[4].Equals('1'))
                    pictureBox5.Image = Properties.Resources.on1;
                else
                    pictureBox5.Image = Properties.Resources.off1;

                if (output_bin[5].Equals("1"))
                    pictureBox6.Image = Properties.Resources.on1;
                else
                    pictureBox6.Image = Properties.Resources.off1;

                if (output_bin[6].Equals('1'))
                    pictureBox7.Image = Properties.Resources.on1;
                else
                    pictureBox7.Image = Properties.Resources.off1;

                if (output_bin[7].Equals('1'))
                    pictureBox8.Image = Properties.Resources.on1;
                else
                    pictureBox8.Image = Properties.Resources.off1;

            }
            if (!ctrlr.Equals(""))
                this.txtBox_ctrSeq.Text = ctrlr;
            this.pnl_States.BackgroundImage = img;
        }

        private void btn_jog_Click(object sender, EventArgs e)
        {
            if (!Mode)
            {
                Mode = true;
                pictureBox1.Image = Properties.Resources.off1;
                pictureBox2.Image = Properties.Resources.off1;
                pictureBox3.Image = Properties.Resources.off1;
                pictureBox4.Image = Properties.Resources.off1;
                pictureBox5.Image = Properties.Resources.off1;
                pictureBox6.Image = Properties.Resources.off1;
                pictureBox7.Image = Properties.Resources.off1;
                pictureBox8.Image = Properties.Resources.off1;
            }
            btn_continuous.Enabled = false;
            emu.jog(this);
        }

        public void disableJog()
        {
            Mode = false;
            btn_jog.Enabled = false;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            SAP1 sap1 = new SAP1();
            sap1.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Glossary glossary = new Glossary();
            glossary.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }
    }
}
