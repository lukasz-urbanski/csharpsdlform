using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Helps when enums used in project are being handling
    /// </summary>
    public class EnumUtils
    {
        /// <summary>
        /// "Translate" English enum value to Polish its decription
        /// </summary>
        /// <param name="value">Enum value</param>
        /// <returns>"Translate" description of passed value</returns>
        public static string StringValueOf(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = 
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
        /// <summary>
        /// Returns object of required enum
        /// </summary>
        /// <param name="value">Required enum</param>
        /// <param name="enumType">Points which set of enums should be searched</param>
        /// <returns>Specific value of enums</returns>
        public static object EnumValueOf(string value, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);
            foreach (string name in names)
            {
                if (StringValueOf((Enum)Enum.Parse(enumType, name)).Equals(value))
                {
                    return Enum.Parse(enumType, name);
                }
            }
            throw new ArgumentException("The string is not a description or value of the specified enum.");
        }
    }
}
