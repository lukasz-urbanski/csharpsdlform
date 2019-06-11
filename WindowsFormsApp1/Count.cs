using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Count
    {
        private int A { get; set; }
        private int B { get; set; }
        private int Repeat { get; set; }
        public enum Operations
        {
            dodawnie,
            odejmmowanie,
            mnożenie,
            dzielenie
        }

        public int GetA()
        {
            return this.A;
        }

        public int GetB()
        {
            return this.B;
        }


        public Count(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public int Add()
        {
            return this.A + this.B;
        }

        public List<String> DealWithIt(int a, int b, Operations o, int t)
        {
            List<String> listResult = new List<String>();
            {
                listResult.Add("====================\n");
                listResult.Add($"A = {a}, B = {b}, Działanie = {o}, Liczba działań = {t}\n");
            }            
            for(int i = 0; i < t; i++)
            {
                switch(o)
                {
                    case Operations.dodawnie:
                        listResult.Add($"{a} + {b} = {a + b}\n");
                        b += a;
                        break;
                    case Operations.odejmmowanie:
                        listResult.Add($"{a} - {b} = {a - b}\n");
                        b -= a;
                        break;
                    case Operations.mnożenie:
                        listResult.Add($"{a} * {b} = {a * b}\n");
                        b *= a;
                        break;
                    case Operations.dzielenie:
                        listResult.Add($"{a} / {b} = {a / b}\n");
                        b /= a;
                        break;
                }                
            }
            return listResult;
        }
    }
}