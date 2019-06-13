using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Klasa odpowiedzialna za odczyt pliku XML
    /// </summary>
    public static class XmlReader
    {
        /// <summary>
        /// Pobieranie liczb z pliku XML i zapisch ich do kolekcji typu List
        /// </summary>
        /// <param name="filepath">Pełna ścieżka do pliku</param>
        /// <returns></returns>
        public static List<float> ReadXml(string filepath)
        {            
            List<float> resList = new List<float>();
            string contentInput;
            using (StreamReader reader = new StreamReader(filepath, Encoding.GetEncoding("ISO-8859-9")))
            {
                contentInput = reader.ReadToEnd();
            }

            // "Naprawianie" pliku XML
            string contentFixed = contentInput.Replace("\u0084", "\"").Replace("\u0094", "\"").Replace("\u0096", "--");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(contentFixed);

            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                // Pętla wykonuje się, omijająć linie, które są komentarzami
                if (xmlNode.NodeType != XmlNodeType.Comment)
                {
                    string a = xmlNode.Attributes[0].InnerText;
                    string b = xmlNode.Attributes[1].InnerText;
                    resList.Add(float.Parse(a));
                    resList.Add(float.Parse(b));
                }
            }
            return resList;
        }
    }
}