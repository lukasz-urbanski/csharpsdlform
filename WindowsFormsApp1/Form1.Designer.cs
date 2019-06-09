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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbOper = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Działanie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Powtórzenia:";
            // 
            // tbPowt
            // 
            this.tbPowt.Location = new System.Drawing.Point(91, 37);
            this.tbPowt.Name = "tbPowt";
            this.tbPowt.Size = new System.Drawing.Size(100, 20);
            this.tbPowt.TabIndex = 3;
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(16, 77);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(175, 23);
            this.btGo.TabIndex = 4;
            this.btGo.Text = "Licz!";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.BtGo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 5;
            // 
            // cbOper
            // 
            this.cbOper.FormattingEnabled = true;
            this.cbOper.Location = new System.Drawing.Point(91, 4);
            this.cbOper.Name = "cbOper";
            this.cbOper.Size = new System.Drawing.Size(100, 21);
            this.cbOper.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 450);
            this.Controls.Add(this.cbOper);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbOper;
    }
}

