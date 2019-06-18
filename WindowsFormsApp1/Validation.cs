using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Validation of data that has been inserted
    /// </summary>
    class Validation
    {
        /// <summary>
        /// Method returns true if all imputs are correct
        /// </summary>       
        /// <param name="repreatsString">Number of repeats as string</param>        
        /// <param name="repeatsInt">Corrent nuber of repeats as integer</param>
        /// <returns>True if value in passed to method in string can be conerted to positive number</returns>
        public static bool IfInputIsCorrect(string repreatsString, out int repeatsInt)
        {
            bool repeatsBool = int.TryParse(repreatsString, out repeatsInt);
            return (repeatsBool && repeatsInt > 0);
        }
    }
}