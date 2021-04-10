using System;

namespace Delegate
{

    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте четыре лямбда оператора для выполнения арифметических действий:
    //(Add – сложение, Sub – вычитание, Mul – умножение, Div – деление).
    //Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
    //Лямбда оператор деления должен делать проверку деления на ноль.
    //Написать программу, которая будет выполнять арифметические действия указанные пользователем.


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first veriable.");
            int first = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input second veriable.");
            int second = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input operation: 1- Summ, 2- Sub, 3 - Mul, 4 - Div.");
            int operation = Convert.ToInt16(Console.ReadLine());
            int res = 0;
            switch (operation)
            {
                case 1:
                    Console.WriteLine(Summ(first, second));
                    break;
                case 2:
                    Console.WriteLine(Sub(first, second));
                    break;
                case 3:
                    Console.WriteLine(Mul(first, second));
                    break;
                case 4:
                    if (Div(first, second) == 0)
                        Console.WriteLine("You cannot divide by zero.");
                    else Console.WriteLine(Div(first, second));
                    break;
                default:
                    Console.WriteLine("Operation isn't corect.");
                    break;
            }

            static int Summ(int x, int y) => x + y;
            static int Sub(int x, int y) => x - y;
            static int Mul(int x, int y) => x * y;
            static int Div(int x, int y) => (y == 0) ? 0 : x / y;
        }
    }
}
