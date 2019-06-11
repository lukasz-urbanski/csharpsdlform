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
            this.tbPowt = new System.Windows.Forms.TextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.cbOper = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Działanie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Powtórzenia:";
            // 
            // tbPowt
            // 
            this.tbPowt.Location = new System.Drawing.Point(254, 37);
            this.tbPowt.Name = "tbPowt";
            this.tbPowt.Size = new System.Drawing.Size(100, 20);
            this.tbPowt.TabIndex = 3;
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(16, 64);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(338, 23);
            this.btGo.TabIndex = 4;
            this.btGo.Text = "Licz!";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.BtGo_Click);
            // 
            // cbOper
            // 
            this.cbOper.FormattingEnabled = true;
            this.cbOper.Location = new System.Drawing.Point(74, 37);
            this.cbOper.Name = "cbOper";
            this.cbOper.Size = new System.Drawing.Size(100, 21);
            this.cbOper.TabIndex = 6;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(16, 93);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(338, 173);
            this.lbResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 284);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.cbOper);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.tbPowt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XML Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPowt;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.ComboBox cbOper;
        private System.Windows.Forms.ListBox lbResult;
    }
}

