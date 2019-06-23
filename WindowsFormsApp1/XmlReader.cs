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
    /// This class is used to read XML file
    /// </summary>
    public static class XmlReader
    {
        /// <summary>
        /// Getting numbers from XML file and passing them into list-type collection
        /// </summary>
        /// <param name="filepath">Full path file</param>
        /// <returns></returns>
        public static List<float[]> ReadXml(string filepath)
        {            
            List<float[]> resList = new List<float[]>();
            string contentInput;
            using (StreamReader reader = new StreamReader(filepath, Encoding.GetEncoding("ISO-8859-9")))
            {
                contentInput = reader.ReadToEnd();
            }

            // "Fixing" XML file
            string contentFixed = contentInput.Replace("\u0084", "\"").Replace("\u0094", "\"").Replace("\u0096", "--");

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(contentFixed);

            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                // Skipping lines with comments
                if (xmlNode.NodeType != XmlNodeType.Comment)
                {
                    float[] arrayOfFloats = new float[2];
                    string a = xmlNode.Attributes[0].InnerText;
                    string b = xmlNode.Attributes[1].InnerText;
                    arrayOfFloats[0] = float.Parse(a); // error event
                    arrayOfFloats[1] = float.Parse(b); //error event
                    resList.Add(arrayOfFloats);
                }
            }
            return resList;
        }
    }
}