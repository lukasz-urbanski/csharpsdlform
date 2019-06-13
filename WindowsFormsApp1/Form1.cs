using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
            // Pobranie typów działań do listy rozwijalnej
            this.cbOper.DataSource = Enum.GetValues(typeof(Count.Operations));
            // Mini instrukcja obsługi
            this.lbResult.Items.Add("Aby rozpcząć:\n");
            this.lbResult.Items.Add("1. Kliknij \"Otwórz plik\" i wybierz plik *.xml.\n");
            this.lbResult.Items.Add("2. Wybierz działanie z listy rozwijalnej\n");
            this.lbResult.Items.Add("3. Podaj liczbę powtórzeń działań.\n");
        }

        string xmlFilename;
        string xmlFilePath;
        Count.Operations inputOperation;
        int inputRepeats;

        /// <summary>
        /// Obsługa przycisku btOpenFile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Przypisanie pełnej ścieżki pliku
                this.xmlFilePath = ofd.FileName;
                // Przypisanie nazwy pliku
                this.xmlFilename = ofd.SafeFileName;
                // Odblokowanie przycisku btGO
                this.btGo.Enabled = true;
            }
            this.tbFilename.Text = xmlFilename;
            
        }
        /// <summary>
        /// Obsługa przycisku btGo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtGo_Click(object sender, EventArgs e)
        {
            // Wyczyszczenie listboxa
            lbResult.Items.Clear();

            // Pobranie liczb z pliku XML
            List<float> numbers = XmlReader.ReadXml(xmlFilePath);

            // Stworznie listy instancji klasy Count
            List<Count> counts = new List<Count>();
            for(int i = 0; i < numbers.Count(); i += 2)
            {
                counts.Add(new Count(numbers[i], numbers[i + 1]));
            }

            // Sprawdzenie poprawności wprowadzonych danych
            if(Validation.IfInputIsCorrect(this.cbOper.Text, this.tbRepeats.Text, out inputOperation, out inputRepeats))
            {
                foreach (Count c in counts)
                {
                    foreach (String str in c.DealWithIt(c.GetA(), c.GetB(), inputOperation, inputRepeats))
                    {
                        lbResult.Items.Add(str);
                    }
                }
                lbResult.Items.Add("====================");
            } else
            {
                lbResult.Items.Add("Musisz podać liczbę całkowitą większą od 0.");
                return;
            }    
        }
    }
}