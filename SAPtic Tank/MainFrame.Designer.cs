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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assemblebin = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBinFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.assemblingProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.assemblerButton = new MetroFramework.Controls.MetroTile();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.log = new System.Windows.Forms.RichTextBox();
            this.logContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.output = new MetroFramework.Controls.MetroLabel();
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
            this.timeSlot = new System.Windows.Forms.Label();
            this.txtBox_pcounter = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.assemblyCode = new System.Windows.Forms.TextBox();
            this.machineCode = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.logContextMenuStrip.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.assemblerToolStripMenuItem,
            this.toolStripMenuItem8});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.save,
            this.saveAs,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.newToolStripMenuItem.Text = "New SAP-1 File";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.loadToolStripMenuItem.Text = "Load/View SAP-1 File";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(213, 22);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAs
            // 
            this.saveAs.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(213, 22);
            this.saveAs.Text = "Save As...";
            this.saveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // assemblerToolStripMenuItem
            // 
            this.assemblerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assemblebin,
            this.loadBinFileToolStripMenuItem});
            this.assemblerToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblerToolStripMenuItem.Name = "assemblerToolStripMenuItem";
            this.assemblerToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.assemblerToolStripMenuItem.Text = "Assembler";
            // 
            // assemblebin
            // 
            this.assemblebin.Enabled = false;
            this.assemblebin.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblebin.Name = "assemblebin";
            this.assemblebin.Size = new System.Drawing.Size(230, 22);
            this.assemblebin.Text = "Assemble/Create bin file";
            this.assemblebin.Click += new System.EventHandler(this.assembleCreateBinFileToolStripMenuItem_Click);
            // 
            // loadBinFileToolStripMenuItem
            // 
            this.loadBinFileToolStripMenuItem.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBinFileToolStripMenuItem.Name = "loadBinFileToolStripMenuItem";
            this.loadBinFileToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.loadBinFileToolStripMenuItem.Text = "Load bin file";
            this.loadBinFileToolStripMenuItem.Click += new System.EventHandler(this.loadBinFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.toolStripMenuItem8.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(52, 22);
            this.toolStripMenuItem8.Text = "Help";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem9.Text = "SAP-1 Architecture";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem10.Text = "Glossary";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(191, 22);
            this.toolStripMenuItem11.Text = "About";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage1);
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Location = new System.Drawing.Point(20, 96);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(931, 570);
            this.metroTabControl2.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.metroTabPage1.Size = new System.Drawing.Size(923, 531);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Assembler";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabPage1.ToolTipText = "SAP-1 Assembler";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.assemblingProgress);
            this.metroPanel2.Controls.Add(this.assemblerButton);
            this.metroPanel2.Controls.Add(this.inputText);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(500, 525);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // assemblingProgress
            // 
            this.assemblingProgress.Location = new System.Drawing.Point(439, 466);
            this.assemblingProgress.Maximum = 100;
            this.assemblingProgress.Name = "assemblingProgress";
            this.assemblingProgress.Size = new System.Drawing.Size(40, 43);
            this.assemblingProgress.Speed = 3F;
            this.assemblingProgress.Spinning = false;
            this.assemblingProgress.Style = MetroFramework.MetroColorStyle.Silver;
            this.assemblingProgress.TabIndex = 4;
            this.assemblingProgress.Theme = MetroFramework.MetroThemeStyle.Light;
            this.assemblingProgress.Visible = false;
            this.assemblingProgress.Click += new System.EventHandler(this.metroProgressSpinner1_Click);
            // 
            // assemblerButton
            // 
            this.assemblerButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.assemblerButton.Enabled = false;
            this.assemblerButton.Location = new System.Drawing.Point(14, 466);
            this.assemblerButton.Name = "assemblerButton";
            this.assemblerButton.Size = new System.Drawing.Size(418, 43);
            this.assemblerButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.assemblerButton.TabIndex = 3;
            this.assemblerButton.Text = "ASSEMBLE";
            this.assemblerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.assemblerButton.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // inputText
            // 
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputText.Enabled = false;
            this.inputText.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(14, 24);
            this.inputText.Name = "inputText";
            this.inputText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputText.Size = new System.Drawing.Size(474, 436);
            this.inputText.TabIndex = 2;
            this.inputText.Text = "";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.log);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(509, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(411, 525);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(16, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 21);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Log:";
            // 
            // log
            // 
            this.log.AcceptsTab = true;
            this.log.AutoWordSelection = true;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log.ContextMenuStrip = this.logContextMenuStrip;
            this.log.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.Location = new System.Drawing.Point(16, 60);
            this.log.MaxLength = 500;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.log.Size = new System.Drawing.Size(378, 449);
            this.log.TabIndex = 2;
            this.log.Text = "";
            // 
            // logContextMenuStrip
            // 
            this.logContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.logContextMenuStrip.Name = "logContextMenuStrip1";
            this.logContextMenuStrip.Size = new System.Drawing.Size(102, 26);
            this.logContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.logContextMenuStrip1_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(101, 22);
            this.toolStripMenuItem1.Text = "Clear";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.output);
            this.metroTabPage2.Controls.Add(this.btn_continuous);
            this.metroTabPage2.Controls.Add(this.btn_jog);
            this.metroTabPage2.Controls.Add(this.pnl_States);
            this.metroTabPage2.Controls.Add(this.txtBox_ctrSeq);
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.assemblyCode);
            this.metroTabPage2.Controls.Add(this.machineCode);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(923, 531);
            this.metroTabPage2.TabIndex = 2;
            this.metroTabPage2.Text = "Emulator";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(462, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 84);
            this.panel2.TabIndex = 37;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox8.Location = new System.Drawing.Point(390, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 78);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox6.Location = new System.Drawing.Point(282, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 78);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox7.Location = new System.Drawing.Point(336, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 78);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox7.TabIndex = 4;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox5.Location = new System.Drawing.Point(228, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 78);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox4.Location = new System.Drawing.Point(174, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 78);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox2.Location = new System.Drawing.Point(66, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox3.Location = new System.Drawing.Point(120, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAPtic_Tank.Properties.Resources.off1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.output.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.output.Location = new System.Drawing.Point(465, 412);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(51, 19);
            this.output.TabIndex = 36;
            this.output.Text = "Output";
            // 
            // btn_continuous
            // 
            this.btn_continuous.Enabled = false;
            this.btn_continuous.Location = new System.Drawing.Point(804, 397);
            this.btn_continuous.Name = "btn_continuous";
            this.btn_continuous.Size = new System.Drawing.Size(116, 34);
            this.btn_continuous.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_continuous.TabIndex = 35;
            this.btn_continuous.Text = "Continuous";
            this.btn_continuous.Click += new System.EventHandler(this.btn_continuous_Click);
            // 
            // btn_jog
            // 
            this.btn_jog.Enabled = false;
            this.btn_jog.Location = new System.Drawing.Point(682, 397);
            this.btn_jog.Name = "btn_jog";
            this.btn_jog.Size = new System.Drawing.Size(116, 34);
            this.btn_jog.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_jog.TabIndex = 34;
            this.btn_jog.Text = "Jog";
            this.btn_jog.Click += new System.EventHandler(this.btn_jog_Click);
            // 
            // pnl_States
            // 
            this.pnl_States.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnl_States.BackgroundImage = global::SAPtic_Tank.Properties.Resources.state4HLT;
            this.pnl_States.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_States.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_States.Location = new System.Drawing.Point(501, 27);
            this.pnl_States.Name = "pnl_States";
            this.pnl_States.Size = new System.Drawing.Size(419, 364);
            this.pnl_States.TabIndex = 33;
            // 
            // txtBox_ctrSeq
            // 
            this.txtBox_ctrSeq.Font = new System.Drawing.Font("Digital-7 Mono", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_ctrSeq.Location = new System.Drawing.Point(5, 434);
            this.txtBox_ctrSeq.Multiline = true;
            this.txtBox_ctrSeq.Name = "txtBox_ctrSeq";
            this.txtBox_ctrSeq.Size = new System.Drawing.Size(451, 87);
            this.txtBox_ctrSeq.TabIndex = 32;
            this.txtBox_ctrSeq.Text = "001111100011";
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
            this.panel1.Controls.Add(this.timeSlot);
            this.panel1.Controls.Add(this.txtBox_pcounter);
            this.panel1.Location = new System.Drawing.Point(296, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 364);
            this.panel1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Output - Register";
            // 
            // txtBox_outReg
            // 
            this.txtBox_outReg.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "B - Register";
            // 
            // txtBox_bReg
            // 
            this.txtBox_bReg.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Accumulator";
            // 
            // txtBox_Acc
            // 
            this.txtBox_Acc.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Acc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_Acc.Location = new System.Drawing.Point(18, 212);
            this.txtBox_Acc.Multiline = true;
            this.txtBox_Acc.Name = "txtBox_Acc";
            this.txtBox_Acc.Size = new System.Drawing.Size(158, 28);
            this.txtBox_Acc.TabIndex = 26;
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
            this.txtBox_IR.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_IR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_IR.Location = new System.Drawing.Point(18, 158);
            this.txtBox_IR.Multiline = true;
            this.txtBox_IR.Name = "txtBox_IR";
            this.txtBox_IR.Size = new System.Drawing.Size(158, 28);
            this.txtBox_IR.TabIndex = 24;
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
            this.txtBox_MAR.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_MAR.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_MAR.Location = new System.Drawing.Point(18, 104);
            this.txtBox_MAR.Multiline = true;
            this.txtBox_MAR.Name = "txtBox_MAR";
            this.txtBox_MAR.Size = new System.Drawing.Size(158, 28);
            this.txtBox_MAR.TabIndex = 22;
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
            // timeSlot
            // 
            this.timeSlot.AutoSize = true;
            this.timeSlot.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSlot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeSlot.Location = new System.Drawing.Point(14, 7);
            this.timeSlot.Name = "timeSlot";
            this.timeSlot.Size = new System.Drawing.Size(65, 20);
            this.timeSlot.TabIndex = 20;
            this.timeSlot.Text = "Time Slot";
            // 
            // txtBox_pcounter
            // 
            this.txtBox_pcounter.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_pcounter.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBox_pcounter.Location = new System.Drawing.Point(18, 50);
            this.txtBox_pcounter.Multiline = true;
            this.txtBox_pcounter.Name = "txtBox_pcounter";
            this.txtBox_pcounter.Size = new System.Drawing.Size(158, 28);
            this.txtBox_pcounter.TabIndex = 8;
            this.txtBox_pcounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel3.Location = new System.Drawing.Point(5, 412);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Contoller";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(129, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Assembly Code";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(2, 27);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Machine Code";
            // 
            // assemblyCode
            // 
            this.assemblyCode.AcceptsReturn = true;
            this.assemblyCode.AcceptsTab = true;
            this.assemblyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assemblyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.assemblyCode.Enabled = false;
            this.assemblyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assemblyCode.Location = new System.Drawing.Point(132, 49);
            this.assemblyCode.MaxLength = 500;
            this.assemblyCode.Multiline = true;
            this.assemblyCode.Name = "assemblyCode";
            this.assemblyCode.ReadOnly = true;
            this.assemblyCode.Size = new System.Drawing.Size(158, 342);
            this.assemblyCode.TabIndex = 3;
            this.assemblyCode.TabStop = false;
            // 
            // machineCode
            // 
            this.machineCode.AcceptsReturn = true;
            this.machineCode.AcceptsTab = true;
            this.machineCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineCode.Enabled = false;
            this.machineCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machineCode.Location = new System.Drawing.Point(5, 49);
            this.machineCode.MaxLength = 500;
            this.machineCode.Multiline = true;
            this.machineCode.Name = "machineCode";
            this.machineCode.ReadOnly = true;
            this.machineCode.Size = new System.Drawing.Size(112, 342);
            this.machineCode.TabIndex = 2;
            this.machineCode.TabStop = false;
            this.machineCode.Text = "00H\r\n01H\r\n02H\r\n03H\r\n04H\r\n05H\r\n06H\r\n09H\r\n0AH\r\n0BH\r\n0CH\r\n0DH\r\n0EH\r\n0FH";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(974, 711);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "saptic tank";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Right;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.logContextMenuStrip.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assemblebin;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.RichTextBox log;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroProgressSpinner assemblingProgress;
        private MetroFramework.Controls.MetroTile assemblerButton;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.ContextMenuStrip logContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadBinFileToolStripMenuItem;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btn_continuous;
        private MetroFramework.Controls.MetroButton btn_jog;
        private System.Windows.Forms.Panel pnl_States;
        private System.Windows.Forms.TextBox txtBox_ctrSeq;
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
        private System.Windows.Forms.Label timeSlot;
        private System.Windows.Forms.TextBox txtBox_pcounter;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.TextBox assemblyCode;
        private System.Windows.Forms.TextBox machineCode;
        private MetroFramework.Controls.MetroLabel output;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}