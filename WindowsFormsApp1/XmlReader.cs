using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

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

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(contentInput);

            foreach (XmlNode xmlNode in xmlDocument.DocumentElement)
            {
                // Skipping lines with comments
                if ((xmlNode.NodeType != XmlNodeType.Comment) & (xmlNode.Name=="value"))
                {
                    //MessageBox.Show("dd");
                    float[] arrayOfFloats = new float[2];
                    try
                    {   
                        if ((xmlNode.Attributes["a"]!= null) & (xmlNode.Attributes["b"]!= null))
                        {
                            arrayOfFloats[0] = float.Parse(xmlNode.Attributes["a"].InnerText);
                            arrayOfFloats[1] = float.Parse(xmlNode.Attributes["b"].InnerText);
                        }
                        else      
                        {
                            if ((xmlNode.Attributes["numberA"]!= null) & (xmlNode.Attributes["numberB"]!= null))
                            {
                                //arrayOfFloats[0] = 5;
                                arrayOfFloats[0] = float.Parse(xmlNode.Attributes["numberA"].InnerText);
                                arrayOfFloats[1] = float.Parse(xmlNode.Attributes["numberB"].InnerText);
                            }
                            else
                            {
                                if (xmlNode.HasChildNodes)
                                {
                                    XmlNodeList ValueChildrens = xmlNode.ChildNodes;
                                    foreach( XmlNode ValueChild in xmlNode.ChildNodes)
                                    {   
                                        switch (ValueChild.Name)
                                            {
                                            case "first":
                                                arrayOfFloats[0] = float.Parse(ValueChild.InnerText);
                                                break;
                                            case "second":
                                                arrayOfFloats[1] = float.Parse(ValueChild.InnerText);
                                                break;
                                            }

                                    }

                        
                                }          
                            }
                        }


                        if ((arrayOfFloats[0]==null) | (arrayOfFloats[0] == null))
                        {
                            throw new System.ArgumentException("Value doesn't have two valid attributes","Read Attributes");
                        }
                    }
                    catch(ArgumentException e)
                    {
                       // log.SaveLogFile(Form1.tbErrorLog.Text, (Log.ErrorLogType)EnumUtils.EnumValueOf(Form1.errorlogcomboBox.SelectedItem.ToString(), typeof(Log.ErrorLogType)), e.Message);
                    }
                    //catch(Exception e)

                   // {
//MessageBox.Show(e.ToString());
//}

                    //string a = xmlNode.Attributes[0].InnerText;
                    //string b = xmlNode.Attributes[1].InnerText;
                    //arrayOfFloats[0] = float.Parse(a); // error event
                    //arrayOfFloats[1] = float.Parse(b); //error event
                    resList.Add(arrayOfFloats);
                }
            }
            return resList;
        }
    }
}