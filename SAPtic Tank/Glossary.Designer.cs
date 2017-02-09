namespace SAPtic_Tank
{
    partial class Glossary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glossary));
            this.terms = new System.Windows.Forms.ListBox();
            this.definition = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // terms
            // 
            this.terms.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terms.FormattingEnabled = true;
            this.terms.ItemHeight = 21;
            this.terms.Items.AddRange(new object[] {
            "Accumulator",
            "Adder/Subtractor",
            "B Register",
            "Binary Display",
            "Controller Sequencer",
            "Fetch Cycle",
            "Input and MAR",
            "Instruction Register",
            "Output Register",
            "Program Counter",
            "RAM"});
            this.terms.Location = new System.Drawing.Point(30, 75);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(153, 298);
            this.terms.TabIndex = 0;
            this.terms.SelectedIndexChanged += new System.EventHandler(this.terms_SelectedIndexChanged);
            // 
            // definition
            // 
            this.definition.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.definition.Location = new System.Drawing.Point(189, 75);
            this.definition.Name = "definition";
            this.definition.Size = new System.Drawing.Size(161, 303);
            this.definition.TabIndex = 1;
            this.definition.Text = "";
            // 
            // Glossary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 410);
            this.Controls.Add(this.definition);
            this.Controls.Add(this.terms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Glossary";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Glossary";
            this.Load += new System.EventHandler(this.Glossary_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox terms;
        private System.Windows.Forms.RichTextBox definition;
    }
}