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
            this.errorlogcomboBox = new System.Windows.Forms.ComboBox();
            this.tbErrorLog = new System.Windows.Forms.TextBox();
            this.BrowseErrorLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Działanie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Powtórzenia:";
            // 
            // repeatsTextBox
            // 
            this.repeatsTextBox.Location = new System.Drawing.Point(344, 66);
            this.repeatsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.repeatsTextBox.Name = "repeatsTextBox";
            this.repeatsTextBox.Size = new System.Drawing.Size(103, 22);
            this.repeatsTextBox.TabIndex = 3;
            // 
            // countButton
            // 
            this.countButton.Enabled = false;
            this.countButton.Location = new System.Drawing.Point(21, 106);
            this.countButton.Margin = new System.Windows.Forms.Padding(4);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(427, 31);
            this.countButton.TabIndex = 4;
            this.countButton.Text = "Licz!";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // operationsComboBox
            // 
            this.operationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationsComboBox.FormattingEnabled = true;
            this.operationsComboBox.Location = new System.Drawing.Point(103, 66);
            this.operationsComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.operationsComboBox.Name = "operationsComboBox";
            this.operationsComboBox.Size = new System.Drawing.Size(120, 24);
            this.operationsComboBox.TabIndex = 6;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 16;
            this.resultsListBox.Location = new System.Drawing.Point(21, 156);
            this.resultsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(425, 196);
            this.resultsListBox.TabIndex = 7;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(21, 20);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(203, 31);
            this.openFileButton.TabIndex = 8;
            this.openFileButton.Text = "Otwórz plik";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(245, 23);
            this.tbFilename.Margin = new System.Windows.Forms.Padding(4);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.ReadOnly = true;
            this.tbFilename.Size = new System.Drawing.Size(201, 22);
            this.tbFilename.TabIndex = 9;
            // 
            // errorlogcomboBox
            // 
            this.errorlogcomboBox.FormattingEnabled = true;
            this.errorlogcomboBox.Location = new System.Drawing.Point(476, 21);
            this.errorlogcomboBox.Name = "errorlogcomboBox";
            this.errorlogcomboBox.Size = new System.Drawing.Size(132, 24);
            this.errorlogcomboBox.TabIndex = 10;
            this.errorlogcomboBox.SelectionChangeCommitted += new System.EventHandler(this.errorlogcomboBox_SelectionChangeCommitted);
            // 
            // tbErrorLog
            // 
            this.tbErrorLog.Enabled = false;
            this.tbErrorLog.Location = new System.Drawing.Point(476, 65);
            this.tbErrorLog.Name = "tbErrorLog";
            this.tbErrorLog.Size = new System.Drawing.Size(293, 22);
            this.tbErrorLog.TabIndex = 11;
            // 
            // BrowseErrorLog
            // 
            this.BrowseErrorLog.Location = new System.Drawing.Point(658, 101);
            this.BrowseErrorLog.Name = "BrowseErrorLog";
            this.BrowseErrorLog.Size = new System.Drawing.Size(110, 35);
            this.BrowseErrorLog.TabIndex = 12;
            this.BrowseErrorLog.Text = "Browse";
            this.BrowseErrorLog.UseVisualStyleBackColor = true;
            this.BrowseErrorLog.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.countButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 366);
            this.Controls.Add(this.BrowseErrorLog);
            this.Controls.Add(this.tbErrorLog);
            this.Controls.Add(this.errorlogcomboBox);
            this.Controls.Add(this.tbFilename);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.operationsComboBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.repeatsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox errorlogcomboBox;
        private System.Windows.Forms.TextBox tbErrorLog;
        private System.Windows.Forms.Button BrowseErrorLog;
    }
}

