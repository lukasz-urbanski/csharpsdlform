using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Form1
    /// </summary>
    public partial class Form1 : Form
    {
        Log log = new Log();
        public Form1()
        {
            InitializeComponent();
            // Getting types of operations into combo box       

            // this.operationsComboBox.DataSource = Enum.GetValues(typeof(Count.Operations));

            foreach (Enum e in Enum.GetValues(typeof(Count.Operations)))
            {
                this.operationsComboBox.Items.Add(EnumUtils.StringValueOf(e));
            }

            operationsComboBox.SelectedIndex = 0;

            foreach (Enum e in Enum.GetValues(typeof(Log.ErrorLogType)))
            {
                this.errorlogcomboBox.Items.Add(EnumUtils.StringValueOf(e));
            }
            errorlogcomboBox.SelectedIndex = 0;

            // "Mini user guide"
            this.resultsListBox.Items.Add("Aby rozpcząć:\n");
            this.resultsListBox.Items.Add("1. Kliknij \"Otwórz plik\" i wybierz plik *.xml.\n");
            this.resultsListBox.Items.Add("2. Wybierz działanie z listy rozwijalnej\n");
            this.resultsListBox.Items.Add("3. Podaj liczbę powtórzeń działań.\n");
        }

        string xmlFilename;
        string xmlFilePath;
        string foldername="";
        int inputRepeats;

        /// <summary>
        /// Handling pressing openFileButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Full file path as variable
                this.xmlFilePath = ofd.FileName;
                // File name as variable
                this.xmlFilename = ofd.SafeFileName;
                this.foldername = Path.GetDirectoryName(xmlFilePath);
                // OpenFileButton is set to active
                this.countButton.Enabled = true;
            }
            this.tbFilename.Text = xmlFilename;
            this.tbErrorLog.Text = Path.Combine(foldername, "log."+ errorlogcomboBox.SelectedItem.ToString());
        }
        private void Browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.tbErrorLog.Text = Path.Combine(fbd.SelectedPath, "log." + errorlogcomboBox.SelectedItem.ToString());
                }

            }

        }
        /// <summary>
        /// Handling pressing countButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountButton_Click(object sender, EventArgs e)
        {
            
            
            
            // Clearing list box
            resultsListBox.Items.Clear();

            if(!Validation.IfInputIsCorrect(this.repeatsTextBox.Text, out inputRepeats))
            {
                string message = "Musisz podać liczbę całkowitą większą od 0.";
                resultsListBox.Items.Add(message);
                message = "Ilość operacji. " + message;
                this.log.SaveLogFile(this.tbErrorLog.Text, (Log.ErrorLogType)EnumUtils.EnumValueOf(errorlogcomboBox.SelectedItem.ToString(), typeof(Log.ErrorLogType)), message);
                
                return;
            }

            // Getting numbers from XML file
            List<float[]> numbers = XmlReader.ReadXml(xmlFilePath);

            // Creating list of instaces of class Clunt
            List<Count> counts = new List<Count>();
            for (int i = 0; i < numbers.Count(); i ++)
            {
                counts.Add(new Count(numbers[i].ElementAt(0), numbers[i].ElementAt(1)));
                

            }

            // Filling list box
            foreach (Count c in counts)
            {
                foreach (String str in c.CalucaltionsAndReturningThemAsString(c.GetA(), c.GetB(), (Count.Operations)EnumUtils.EnumValueOf(operationsComboBox.Text, typeof(Count.Operations)), inputRepeats))
                {
                    resultsListBox.Items.Add(str);                    
                }
            }
            resultsListBox.Items.Add("========================================");
            if (MessageBox.Show("Do you want to opent log file?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                Process.Start(this.tbErrorLog.Text);
            }
            


        }

        private void errorlogcomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.tbErrorLog.Text.Length > 0)
            {
                this.tbErrorLog.Text = Path.Combine(Path.GetDirectoryName(this.tbErrorLog.Text), "log." + errorlogcomboBox.SelectedItem);
            }
            
        }


    }
}
