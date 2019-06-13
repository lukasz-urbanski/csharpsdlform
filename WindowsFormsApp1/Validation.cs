using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Sprawdzenie poprawności wprowadzonych danych
    /// </summary>
    class Validation
    {
        /// <summary>
        /// Metoda zwracająca PRAWDĘ, jeśli wprowadzono poprawne dane
        /// </summary>
        /// <param name="operationString">Rodziaj operacji jako string</param>
        /// <param name="repreatsString">Ilość powtórzeń jako string</param>
        /// <param name="operationEnum">Poprawna operacja jako enum</param>
        /// <param name="repeatsInt">Poprawna liczba powtórzeń jako int</param>
        /// <returns></returns>
        public static bool IfInputIsCorrect(
            string operationString, string repreatsString,
            out Count.Operations operationEnum, out int repeatsInt)
        {
            bool operationBool =
                Enum.TryParse<Count.Operations>(operationString, out operationEnum);

            bool repeatsBool = int.TryParse(repreatsString, out repeatsInt);

            // Metoda zwraca PRAWDĘ jeśli spełnione są wszystkie te warunki:
            // 1. Został prawdłowo wybrana rodzaj operacji.
            // 2. Liczba powtórzeń ma wartość liczbową.
            // 3. Liczba powtórzeń jest większa od 0.
            return (operationBool && repeatsBool && repeatsInt > 0);
        }
    }
}