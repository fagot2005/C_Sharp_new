using System;

namespace Calculator
{
    class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Sub(int first, int second)
        {
            return first - second;
        }

        public int Mul(int first, int second)
        {
            return first * second;
        }

        public double Div(int first, int second)
        {
            if (second == 0)
            {
                throw new ArgumentException("Делит на 0 нельзя!!!");
            }
            return (double)first / second;
        }
    }
}
