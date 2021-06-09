using System;

namespace Addition_task
{
    class Program
    {
        //        Создайте структуру описывающую точку в трехмерной системе координат.
        //        Организуйте возможность сложения двух точек, через использование перегрузки оператора +. "

        static void Main(string[] args)
        {
            Point a = new Point(2, 3, 4);
            Point b = new Point(5, 10, 15);
            Point c = a + b;

            Console.WriteLine("Point a: {0}, {1}, {2}", a.X, a.Y, a.Z);
            Console.WriteLine("Point b: {0}, {1}, {2}", b.X, b.Y, b.Z);
            Console.WriteLine("Point c: {0}, {1}, {2}", c.X, c.Y, c.Z);
            Console.ReadKey();
        }
    }
}
