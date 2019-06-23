using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
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
        private void SaveLogFile(string path, Log.ErrorLogType type, string message)
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
                    break;

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
                    return "\""+ AddQuotes(DateTime.Now.ToString()) + "\",\"" + AddQuotes(message) + "\"";
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
    }
}
