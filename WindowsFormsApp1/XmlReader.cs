using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WindowsFormsApp1
{
    public static class XmlReader
    {
        public static List<int> ReadXml()
        {            
            List<int> resList = new List<int>();
            string contentInput;
            using (StreamReader reader = new StreamReader("test.xml", Encoding.GetEncoding("ISO-8859-9")))
            {
                contentInput = reader.ReadToEnd();
            }

            string contentFixed = contentInput.Replace("\u0084", "\"").Replace("\u0094", "\"").Replace("\u0096", "--");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(contentFixed);

            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                if (xmlNode.NodeType != XmlNodeType.Comment)
                {
                    string a = xmlNode.Attributes[0].InnerText;
                    string b = xmlNode.Attributes[1].InnerText;
                    resList.Add(int.Parse(a));
                    resList.Add(int.Parse(b));
                }
            }
            return resList;
        }
    }
}