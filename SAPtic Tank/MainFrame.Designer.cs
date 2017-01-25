namespace SAPtic_Tank
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assembleCreateBinFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_continuous = new MetroFramework.Controls.MetroButton();
            this.btn_jog = new MetroFramework.Controls.MetroButton();
            this.pnl_States = new System.Windows.Forms.Panel();
            this.txtBox_ctrSeq = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_outReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_bReg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBox_Acc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_IR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_MAR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_pcounter = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.assemblyCode = new System.Windows.Forms.TextBox();
            this.machineCode = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assemblerToolStripMenuItem,
            this.toolStripMenuItem8});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.loadToolStripMenuItem.Text = "Load/View SAP-1 File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // assemblerToolStripMenuItem
            // 
            this.assemblerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assembleCreateBinFileToolStripMenuItem});
            this.assemblerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblerToolStripMenuItem.Name = "assemblerToolStripMenuItem";
            this.assemblerToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.assemblerToolStripMenuItem.Text = "Assembler";
            // 
            // assembleCreateBinFileToolStripMenuItem
            // 
            this.assembleCreateBinFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assembleCreateBinFileToolStripMenuItem.Name = "assembleCreateBinFileToolStripMenuItem";
            this.assembleCreateBinFileToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.assembleCreateBinFileToolStripMenuItem.Text = "Assemble/Create bin file";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem8.Text = "Help";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(202, 24);
            this.toolStripMenuItem9.Text = "SAP-1 Architecture";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(202, 24);
            this.toolStripMenuItem10.Text = "Glossary";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(202, 24);
            this.toolStripMenuItem11.Text = "About";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(20, 96);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(931, 570);
            this.metroTabControl1.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(923, 531);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Assembler";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_continuous);
            this.metroTabPage2.Controls.Add(this.btn_jog);
            this.metroTabPage2.Controls.Add(this.pnl_States);
            this.metroTabPage2.Controls.Add(this.txtBox_ctrSeq);
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.assemblyCode);
            this.metroTabPage2.Controls.Add(this.machineCode);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(923, 531);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Emulator";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // btn_continuous
            // 
            this.btn_continuous.Location = new System.Drawing.Point(623, 397);
            this.btn_continuous.Name = "btn_continuous";
            this.btn_continuous.Size = new System.Drawing.Size(116, 34);
            this.btn_continuous.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_continuous.TabIndex = 35;
            this.btn_continuous.Text = "Continuous";
            // 
            // btn_jog
            // 
            this.btn_jog.Location = new System.Drawing.Point(501, 397);
            this.btn_jog.Name = "btn_jog";
            this.btn_jog.Size = new System.Drawing.Size(116, 34);
            this.btn_jog.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_jog.TabIndex = 34;
            this.btn_jog.Text = "Jog";
            // 
            // pnl_States
            // 
            this.pnl_States.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_States.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_States.BackgroundImage")));
            this.pnl_States.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_States.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_States.Location = new System.Drawing.Point(501, 27);
            this.pnl_States.Name = "pnl_States";
            this.pnl_States.Size = new System.Drawing.Size(419, 364);
            this.pnl_States.TabIndex = 33;
            this.pnl_States.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtBox_ctrSeq
            // 
            this.txtBox_ctrSeq.Enabled = false;
            this.txtBox_ctrSeq.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ctrSeq.Location = new System.Drawing.Point(5, 434);
            this.txtBox_ctrSeq.Multiline = true;
            this.txtBox_ctrSeq.Name = "txtBox_ctrSeq";
            this.txtBox_ctrSeq.Size = new System.Drawing.Size(239, 87);
            this.txtBox_ctrSeq.TabIndex = 32;
            this.txtBox_ctrSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtBox_outReg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBox_bReg);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBox_Acc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtBox_IR);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBox_MAR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBox_pcounter);
            this.panel1.Location = new System.Drawing.Point(270, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 364);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Out - Register";
            // 
            // txtBox_outReg
            // 
            this.txtBox_outReg.Enabled = false;
            this.txtBox_outReg.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_outReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_outReg.Location = new System.Drawing.Point(18, 320);
            this.txtBox_outReg.Multiline = true;
            this.txtBox_outReg.Name = "txtBox_outReg";
            this.txtBox_outReg.Size = new System.Drawing.Size(158, 28);
            this.txtBox_outReg.TabIndex = 30;
            this.txtBox_outReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(14, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "B - Register";
            // 
            // txtBox_bReg
            // 
            this.txtBox_bReg.Enabled = false;
            this.txtBox_bReg.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_bReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_bReg.Location = new System.Drawing.Point(18, 266);
            this.txtBox_bReg.Multiline = true;
            this.txtBox_bReg.Name = "txtBox_bReg";
            this.txtBox_bReg.Size = new System.Drawing.Size(158, 28);
            this.txtBox_bReg.TabIndex = 28;
            this.txtBox_bReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(14, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Accumulator";
            // 
            // txtBox_Acc
            // 
            this.txtBox_Acc.Enabled = false;
            this.txtBox_Acc.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Acc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_Acc.Location = new System.Drawing.Point(18, 212);
            this.txtBox_Acc.Multiline = true;
            this.txtBox_Acc.Name = "txtBox_Acc";
            this.txtBox_Acc.Size = new System.Drawing.Size(158, 28);
            this.txtBox_Acc.TabIndex = 26;
            this.txtBox_Acc.Text = "64H";
            this.txtBox_Acc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "IR";
            // 
            // txtBox_IR
            // 
            this.txtBox_IR.Enabled = false;
            this.txtBox_IR.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_IR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_IR.Location = new System.Drawing.Point(18, 158);
            this.txtBox_IR.Multiline = true;
            this.txtBox_IR.Name = "txtBox_IR";
            this.txtBox_IR.Size = new System.Drawing.Size(158, 28);
            this.txtBox_IR.TabIndex = 24;
            this.txtBox_IR.Text = "0000";
            this.txtBox_IR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "MAR";
            // 
            // txtBox_MAR
            // 
            this.txtBox_MAR.Enabled = false;
            this.txtBox_MAR.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_MAR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_MAR.Location = new System.Drawing.Point(18, 104);
            this.txtBox_MAR.Multiline = true;
            this.txtBox_MAR.Name = "txtBox_MAR";
            this.txtBox_MAR.Size = new System.Drawing.Size(158, 28);
            this.txtBox_MAR.TabIndex = 22;
            this.txtBox_MAR.Text = "0000";
            this.txtBox_MAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Program Counter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "T State";
            // 
            // txtBox_pcounter
            // 
            this.txtBox_pcounter.Enabled = false;
            this.txtBox_pcounter.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_pcounter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_pcounter.Location = new System.Drawing.Point(18, 50);
            this.txtBox_pcounter.Multiline = true;
            this.txtBox_pcounter.Name = "txtBox_pcounter";
            this.txtBox_pcounter.Size = new System.Drawing.Size(158, 28);
            this.txtBox_pcounter.TabIndex = 8;
            this.txtBox_pcounter.Text = "0000";
            this.txtBox_pcounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.Location = new System.Drawing.Point(5, 412);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(123, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Contoller Sequence";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(129, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Assembly Code";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(2, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Machine Code";
            // 
            // assemblyCode
            // 
            this.assemblyCode.Enabled = false;
            this.assemblyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblyCode.Location = new System.Drawing.Point(132, 49);
            this.assemblyCode.Multiline = true;
            this.assemblyCode.Name = "assemblyCode";
            this.assemblyCode.Size = new System.Drawing.Size(112, 342);
            this.assemblyCode.TabIndex = 3;
            // 
            // machineCode
            // 
            this.machineCode.Enabled = false;
            this.machineCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCode.Location = new System.Drawing.Point(5, 49);
            this.machineCode.Multiline = true;
            this.machineCode.Name = "machineCode";
            this.machineCode.Size = new System.Drawing.Size(112, 342);
            this.machineCode.TabIndex = 2;
            this.machineCode.Text = "0H\r\n1H\r\n2H\r\n3H\r\n4H\r\n5H\r\n6H\r\n9H\r\nAH\r\nBH\r\nCH\r\nDH\r\nEH\r\nFH";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAPtic_Tank.Properties.Resources.wpid_wp_14240517395271;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(974, 711);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "saptic tank";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assembleCreateBinFileToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox assemblyCode;
        private System.Windows.Forms.TextBox machineCode;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox txtBox_pcounter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_outReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_bReg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBox_Acc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_IR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_MAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_ctrSeq;
        private System.Windows.Forms.Panel pnl_States;
        private MetroFramework.Controls.MetroButton btn_continuous;
        private MetroFramework.Controls.MetroButton btn_jog;
    }
}