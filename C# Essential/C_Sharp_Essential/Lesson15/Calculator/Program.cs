using System;

namespace Calculator
{
    class Program
    {

        //        Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте класс Calculator. 
        //В теле класса создайте четыре метода для арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление).  
        //Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать исключение.
        //Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию.При возникновении ошибок должны выбрасываться исключения. 


        static void Main(string[] args)
        {
            Console.WriteLine("Inpit first int");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inpit second int");
            int second = Convert.ToInt32(Console.ReadLine());
            Calculator calculator = new Calculator();
            Console.WriteLine("Inpit operation: 1- Add, 2 - Sub, 3 - Mul, 4 - Div");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Sum of {0} and {1} = {2}", first, second, calculator.Add(first, second));
                    break;
                case 2:
                    Console.WriteLine("Sub of {0} and {1} = {2}", first, second, calculator.Sub(first, second));
                    break;
                case 3:
                    Console.WriteLine("Mul of {0} and {1} = {2}", first, second, calculator.Mul(first, second));
                    break;
                case 4:
                    Console.WriteLine("Div of {0} and {1} = {2}", first, second, calculator.Div(first, second));
                    break;
                default:
                    Console.WriteLine("Input not imposible operation");
                    break;
            }
        }
    }
}
