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
        /// <param name="operationString">Operation type as string</param>
        /// <param name="repreatsString">Number of repeats as string</param>
        /// <param name="operationEnum">Correct operation as enum</param>
        /// <param name="repeatsInt">Corrent nuber of repeats as integer</param>
        /// <returns></returns>
        public static bool IfInputIsCorrect(
            // string operationString,
            string repreatsString,
            // out Count.Operations operationEnum,
            out int repeatsInt)
        {
            //EnumUtils.EnumValueOf(operationString, typeof(Count.Operations));
            //bool operationBool = Enum.TryParse<Count.Operations>(operationString, out operationEnum);
            // Enum.TryParse<Count.Operations>(operationString, out operationEnum);

            bool repeatsBool = int.TryParse(repreatsString, out repeatsInt);

            // Method returns true if all three conditons are passed:
            // 1. Correct operation has been chosen.
            // 2. Repeats are number.
            // 3. That number is positive.
            return (repeatsBool && repeatsInt > 0);
        }
    }
}