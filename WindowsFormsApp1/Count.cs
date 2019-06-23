using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Class that contains variables to be calculated and operations as emuns
    /// </summary>
    class Count
    {
        #region Class members
        private float A { get; set; }
        private float B { get; set; }
        public enum Operations
        {
            [DescriptionAttribute("Dodawanie")]
            Addition,
            [DescriptionAttribute("Odejmowanie")]
            Subtraction,
            [DescriptionAttribute("Mnożenie")]
            Multiplication,
            [DescriptionAttribute("Dzielenie")]
            Division,
            [DescriptionAttribute("Potęgowanie")]
            exponentiation,
            [DescriptionAttribute("Modulo")]
            modulo
        }
        #endregion
        #region Methods
        /// <summary>
        /// Count class constructor
        /// </summary>
        /// <param name="a">Value of member A</param>
        /// <param name="b">Value of member A</param>
        public Count(float a, float b)
        {
            this.A = a;
            this.B = b;
        }
        public float GetA()
        {
            return this.A;
        }
        public float GetB()
        {
            return this.B;
        }
        /// <summary>
        /// Calculation and sending results to string
        /// </summary>
        /// <param name="numberA">#1 number</param>
        /// <param name="numberB">#2 number</param>
        /// <param name="operation">Type of operation</param>
        /// <param name="repeats">Number of repetitions</param>
        /// <returns></returns>
        public List<String> CalucaltionsAndReturningThemAsString(float numberA, float numberB, Operations operation, int repeats)
        {
            List<String> listResult = new List<String>();
            {
                listResult.Add("========================================");
                listResult.Add($"A = {numberA}, B = {numberB}, Działanie = {EnumUtils.StringValueOf(operation)}, Liczba działań = {repeats}\n");
            }            
            for(int i = 0; i < repeats; i++)
            {
                // Switch loop with type of operations as argument used
                switch(operation)
                {
                    case Operations.Addition:
                        listResult.Add($"[{numberA}] + [{numberB}] = [{numberA + numberB}]\n");
                        numberB = numberA + numberB;
                        break;
                    case Operations.Subtraction:
                        listResult.Add($"[{numberA}] - [{numberB}] = [{numberA - numberB}]\n");
                        numberB = numberA - numberB;
                        break;
                    case Operations.Multiplication:
                        listResult.Add($"[{numberA}] * [{numberB}] = [{numberA * numberB}]\n");
                        numberB = numberA * numberB;
                        break;
                    case Operations.Division:
                        listResult.Add(
                            (String.Format("{0:0.##}", numberA) + " / " + (String.Format("{0:0.##}", numberB)) +
                            " = " + (String.Format("{0:0.##}", numberA / numberB)) + "\n"));
                        numberB = numberA / numberB;
                        break;
                    case Operations.exponentiation:
                        listResult.Add($"[{numberA}] ^ [{numberB}] = [{Math.Pow(System.Convert.ToDouble(numberA), Convert.ToDouble(numberB))}]\n");
                        numberB = Convert.ToSingle(Math.Pow(System.Convert.ToDouble(numberA), Convert.ToDouble(numberB)));
                        break;


                    case Operations.modulo:
                        listResult.Add($"[{numberA}] % [{numberB}] = [{numberA % numberB}]\n");
                        numberB = numberA % numberB;
                        break;
                }                
            }
            return listResult;
        }
        #endregion
    }
}