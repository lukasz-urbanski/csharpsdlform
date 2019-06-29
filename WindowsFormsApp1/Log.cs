using System;
using System.ComponentModel;
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    class Log
    {
        public enum ErrorLogType
        {
            [DescriptionAttribute("TXT")]
            TXT,
            [DescriptionAttribute("CSV")]
            CSV,
            [DescriptionAttribute("TSV")]
            TSV,
            [DescriptionAttribute("XML")]
            XML
        }
        public void SaveLogFile(string path, Log.ErrorLogType type, string message)
        {
            try
            {
                switch (type)
                {
                    case Log.ErrorLogType.TXT:

                        WriteSimpleFormat(path, ConvertMessage(message, type));
                        break;
                    case Log.ErrorLogType.CSV:
                        WriteSimpleFormat(path, ConvertMessage(message, type));
                        break;
                    case Log.ErrorLogType.TSV:
                        WriteSimpleFormat(path, ConvertMessage(message, type));
                        break;
                    case Log.ErrorLogType.XML:
                        WriteXmlFile(path, message);
                        break;

                }
            }
            catch(Exception)
            {

            }
            
        }
        private string ConvertMessage(string message, Log.ErrorLogType type)
        {
            switch (type)
            {
                case Log.ErrorLogType.TXT:
                    return DateTime.Now.ToString() + " " + message;
                    break;
                case Log.ErrorLogType.CSV:
                    return "\"" + AddQuotes(DateTime.Now.ToString()) + "\",\"" + AddQuotes(message) + "\"";
                    break;
                case Log.ErrorLogType.TSV:
                    return "\"" + AddQuotes(DateTime.Now.ToString()) + "\"\t\"" + AddQuotes(message) + "\"";
                    break;
                default:
                    throw new InvalidCastException();
                    break;

            }
        }
        private string AddQuotes(string messages)
        {
            return messages.Replace("\"", "\"\"");

        }
        private void WriteSimpleFormat(string path, string message)
        {
            using (System.IO.StreamWriter logfile =
                new System.IO.StreamWriter(path, true))
            {
                logfile.WriteLine(message);
            }
        }
        private void WriteXmlFile(string path, string message)
        {
            XDocument doc;
            XElement entry;
            if (File.Exists(path))
            {
                doc = XDocument.Load(path);


            }
            else
            {
                doc = new XDocument(new XElement("errorlog"));

                //doc.Save(path);
            }
            entry = doc.Element("errorlog");
            entry.Add(new XElement("entry",
            new XElement("date", DateTime.Now.ToString()),
            new XElement("message", message)));
            doc.Save(path);

        }
    }
}
