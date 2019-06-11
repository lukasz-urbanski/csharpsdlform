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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //cbStatus.DataSource = Enum.GetValues(typeof(Status));
            cbOper.DataSource = Enum.GetValues(typeof(Count.Operations));
        }

        private void BtGo_Click(object sender, EventArgs e)
        {
            lbResult.Items.Clear();

            List<int> numbers = XmlReader.ReadXml();
         
            int counter = numbers.Count;

            var counts = new List<Count>();

            int timesInt;

            bool timesBool = int.TryParse(tbPowt.Text, out timesInt);
            
            Enum.TryParse<Count.Operations>(this.cbOper.SelectedValue.ToString(), out Count.Operations o);

            if (!(timesBool) || !(timesInt>0))
            {
                lbResult.Items.Add("Musisz podać liczbę całkowitą większą od 0.");
                return;
            }

            for (int i = 0; i < counter; i+=2)
            {
                counts.Add(new Count(numbers[i], numbers[i+1]));
            }

            foreach(Count c in counts)
            {
                // lvResult.Items.Add(c.Add().ToString());
                // lvResult.Items.Add(String.Empty);
                foreach (String str in c.DealWithIt(c.GetA(), c.GetB(), o, timesInt))
                {
                    lbResult.Items.Add(str);                    
                }
            }
            lbResult.Items.Add("====================");
        }
    }
}