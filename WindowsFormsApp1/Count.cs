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
            Sum,
            Substract,
            Multiply,
            Divide
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
    }
}
