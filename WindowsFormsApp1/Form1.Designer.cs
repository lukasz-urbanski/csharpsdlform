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
            this.repeatsTextBox = new System.Windows.Forms.TextBox();
            this.countButton = new System.Windows.Forms.Button();
            this.operationsComboBox = new System.Windows.Forms.ComboBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.openFileButton = new System.Windows.Forms.Button();
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
            // repeatsTextBox
            // 
            this.repeatsTextBox.Location = new System.Drawing.Point(258, 54);
            this.repeatsTextBox.Name = "repeatsTextBox";
            this.repeatsTextBox.Size = new System.Drawing.Size(78, 20);
            this.repeatsTextBox.TabIndex = 3;
            // 
            // countButton
            // 
            this.countButton.Enabled = false;
            this.countButton.Location = new System.Drawing.Point(16, 86);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(320, 25);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Licz!";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // operationsComboBox
            // 
            this.operationsComboBox.FormattingEnabled = true;
            this.operationsComboBox.Location = new System.Drawing.Point(77, 54);
            this.operationsComboBox.Name = "operationsComboBox";
            this.operationsComboBox.Size = new System.Drawing.Size(91, 21);
            this.operationsComboBox.TabIndex = 6;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(16, 127);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(320, 160);
            this.resultsListBox.TabIndex = 7;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(16, 16);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(152, 25);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "Otwórz plik";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
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
            this.AcceptButton = this.countButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 297);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.operationsComboBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.repeatsTextBox);
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
        private System.Windows.Forms.TextBox repeatsTextBox;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.ComboBox operationsComboBox;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TextBox tbFilename;
    }
}

