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
        delegate double MyDel(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("Input first veriable.");
            int first = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input second veriable.");
            int second = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Input operation: 1- Summ, 2- Sub, 3 - Mul, 4 - Div.");
            int operation = Convert.ToInt16(Console.ReadLine());
            MyDel resalt = null;
            switch (operation)
            {
                case 1:
                    resalt = (first, second) => first + second;
                    break;
                case 2:
                    resalt = (first, second) => first - second;
                    break;
                case 3:
                    resalt = (first, second) => first * second;
                    break;
                case 4:
                    resalt = (first, second) =>
                    {
                        if (second == 0)
                        {
                            Console.WriteLine("Делить на ноль нельзя");
                            return 0;
                        }
                        else
                            return first / (double)second;
                    };
                    break;
                default:
                    Console.WriteLine("Operation isn't corect.");
                    break;
            }
            if (resalt != null)
                Console.WriteLine(resalt(first, second));
        }
    }
}
