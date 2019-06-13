namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRepeats = new System.Windows.Forms.TextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.cbOper = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Działanie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Powtórzenia:";
            // 
            // tbRepeats
            // 
            this.tbRepeats.Location = new System.Drawing.Point(258, 54);
            this.tbRepeats.Name = "tbRepeats";
            this.tbRepeats.Size = new System.Drawing.Size(78, 20);
            this.tbRepeats.TabIndex = 3;
            // 
            // btGo
            // 
            this.btGo.Enabled = false;
            this.btGo.Location = new System.Drawing.Point(16, 86);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(320, 25);
            this.btGo.TabIndex = 4;
            this.btGo.Text = "Licz!";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.BtGo_Click);
            // 
            // cbOper
            // 
            this.cbOper.FormattingEnabled = true;
            this.cbOper.Location = new System.Drawing.Point(77, 54);
            this.cbOper.Name = "cbOper";
            this.cbOper.Size = new System.Drawing.Size(91, 21);
            this.cbOper.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(16, 127);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(320, 160);
            this.lbResult.TabIndex = 7;
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(16, 16);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(152, 25);
            this.btOpenFile.TabIndex = 8;
            this.btOpenFile.Text = "Otwórz plik";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.BtOpenFile_Click);
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(184, 19);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.ReadOnly = true;
            this.tbFilename.Size = new System.Drawing.Size(152, 20);
            this.tbFilename.TabIndex = 9;
            // 
            // Form1
            // 
            this.AcceptButton = this.btGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 297);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbOper);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.tbRepeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XML Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRepeats;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.ComboBox cbOper;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.TextBox tbFilename;
    }
}

