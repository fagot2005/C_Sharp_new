using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public int First { get; set; }
        public int Second { get; set; }

        public Calculator(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int Add(Calculator calculator)
        {
            return calculator.First + calculator.Second;
        }

        public int Sub (Calculator calculator)
        {
            return calculator.First - calculator.Second;
        }

        public int Mul(Calculator calculator)
        {
            return calculator.First * calculator.Second;
        }

        public double Div(Calculator calculator)
        {
            //Exception ex = new Exception("Div of 0 not emposible");
            if (calculator.Second == 0)
                throw new ArgumentNullException("Div of 0 not emposible");
            return (double) calculator.First / calculator.Second;
        }
    }
}
