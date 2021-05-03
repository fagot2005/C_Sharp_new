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

        public int Sub(Calculator calculator)
        {
            return calculator.First - calculator.Second;
        }

        public int Mul(Calculator calculator)
        {
            return calculator.First * calculator.Second;
        }

        public int? Div(Calculator calculator)
        {
            try
            {
                int res = calculator.First / calculator.Second;
                return res;
            }
            catch (Exception e)
            {
                Console.WriteLine("Сработало исключение");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
