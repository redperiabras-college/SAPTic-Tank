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
        File file = new File();

        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectedTab = metroTabPage1;
            assemblebin.Enabled = true;
            saveAs.Enabled = true;
            inputText.Enabled = true;
            inputText.Focus();
            assemblerButton.Enabled = true;
            inputText.Text = file.assemblerReader();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currTime = DateTime.Now.ToString();
            log.Text += currTime + "\n" + file.save(inputText.Text) + "\n\n";
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
            string status = file.saveAs(inputText.Text);
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
                Assembler ass = new Assembler();
                string output = ass.assemble(inputText.Text);
                file.export(output);
                
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
            metroTabControl1.SelectedTab = metroTabPage1;
            assemblebin.Enabled = true;
            saveAs.Enabled = false;
            if (!inputText.Text.Equals(""))
                inputText.Text = "";
            file.clear();
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
            metroTabControl1.SelectedTab = metroTabPage2;
        }
    }
}
