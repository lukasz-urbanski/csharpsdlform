using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //do *not* add comments in Polish (or anything other than English. Always, but especially at work).
    /// <summary>
    /// Klasa przechowująca zmienne oraz odowiedzialna za wykonanie działań matematycznych 
    /// </summary>
    class Count
    {
        //regions are rather yucky for hiding code :) That's a matter of preference though
        #region Zmienne 
        private float A { get; set; }
        private float B { get; set; }
        public enum Operations 
        {
            dodawnie, //no code should be in Polish - if you need localized UI strings, find a different approach
            odejmmowanie,
            mnożenie,
            dzielenie
        }
        //also - you have wrong operations...

        #endregion
        #region Metody
        /// <summary>
        /// Konstruktor klasy Count
        /// </summary>
        /// <param name="a">Wartość zmienneh A</param>
        /// <param name="b">Wartość zmiennej B</param>
        public Count(float a, float b)
        {
            this.A = a;
            this.B = b;
        }
        // Pobranie zmiennej A i B <-- redundant comment, too obvious, not needed
        public float GetA()
        {
            return this.A;
        }
        public float GetB()
        {
            return this.B;
        }
        /// <summary>
        /// Wykonanie działań i zapisanie wyników do zmiennnej typu string
        /// </summary>
        /// <param name="a">1. liczba</param>
        /// <param name="b">2. liczba</param>
        /// <param name="o">Rodzaj działania</param>
        /// <param name="t">Liczba potwórzeń</param>
        /// <returns></returns>
        public List<String> DealWithIt(float a, float b, Operations o, int t) //questionable method name... not very bad, but almost not correct (in general - avoid 'funny' naming, especially if a clearer name exists)
            //also - what is 't'? 
            //do not use single letter identifiers. Nor abbreviations. Use full names which describe what the variable stands for
        {
            List<String> listResult = new List<String>();
            {
                listResult.Add("====================\n");
                listResult.Add($"A = {a}, B = {b}, Działanie = {o}, Liczba działań = {t}\n");
            }            
            for(int i = 0; i < t; i++)
            {
                // Pętla switch przyjmująca za argumet rodziaj działania
                // Nawiasy kwadratowe dodane dla czytelności <-- redundant comment
                switch(o) //what is 'o'? I forgot, I have to check... I shouldn't have to check:)
                {
                    case Operations.dodawnie:
                        listResult.Add($"[{a}] + [{b}] = [{a + b}]\n");
                        b = a + b;
                        break;
                    case Operations.odejmmowanie:
                        listResult.Add($"[{a}] - [{b}] = [{a - b}]\n");
                        b = a - b;
                        break;
                    case Operations.mnożenie:
                        listResult.Add($"[{a}] * [{b}] = [{a * b}]\n");
                        b = a * b;
                        break;
                    case Operations.dzielenie:
                        listResult.Add(
                            (String.Format("{0:0.##}", a) + " / " + (String.Format("{0:0.##}", b)) +
                            " = " + (String.Format("{0:0.##}", a / b)) + "\n"));
                        b = a / b;
                        break;
                }                
            }
            return listResult;
        }
        #endregion
    }
}