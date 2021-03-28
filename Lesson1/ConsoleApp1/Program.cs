using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 15;
            int c = 50;

            if (VerificationOfParties(a, b, c))
            {
                Perimetr(a, b, c);
                Square(a, b, c);
            }
            Console.ReadKey();
        }

        static void Perimetr(int lineOne, int lineTwo, int lineThree)
        {
            Console.WriteLine("Perimetr a triangle = {0}", (lineOne + lineThree + lineTwo));
        }

        static void Square(int lineOne, int lineTwo, int lineThree)
        {
            Console.WriteLine("Square a triangle = {0}", (lineOne * lineThree * lineTwo));
        }

        static bool VerificationOfParties(int lineOne, int lineTwo, int lineThree)
        {
            bool resalt_bool = false;
            if ((lineOne + lineTwo) > lineThree && (lineOne + lineThree) > lineTwo && (lineThree + lineTwo) > lineOne)
                resalt_bool = true;
            else
                Console.WriteLine("A triangle with such sides {0}x{1}x{2} does not exist", lineOne, lineTwo, lineThree);
            return resalt_bool;
        }
    }
}
