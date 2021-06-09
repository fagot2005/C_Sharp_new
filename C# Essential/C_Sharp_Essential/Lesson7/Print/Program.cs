using System;
//using static System.Net.Mime.MediaTypeNames;

namespace Print
{

    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте статический класс с методом void Print (string stroka, int color), 
    //        который выводит на экран строку заданным цветом.Используя перечисление, 
    //        создайте набор цветов, доступных пользователю. Ввод строки и выбор цвета предоставьте пользователю.


    class Program
    {
        static void Main(string[] args)
        {
            //bool boll = true;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ВВЕДИ СЛОВО");
                string str = Console.ReadLine();
                Console.WriteLine("ВЫБЕРИ ЦВЕТ: СИНИЙ = 9, ЗЕЛЕНЫЙ = 10, ГОЛУБОЙ = 11, КРАСНЫЙ = 12, ПУРПУРНЫЙ = 13, ЖЕЛТЫЙ = 14");
                int color = Convert.ToInt32(Console.ReadLine());
                Print.PrintM(str, color);
                Console.WriteLine("ПРОДОЛЖИТЬ - 1, НЕТ - 2");
                string answer = Console.ReadLine();
                if (String.Equals(answer, "2"))
                    break;
            }
        }

        static class Print
        {
            public static void PrintM(string str, int color)
            {
                ConsoleColor col = new ConsoleColor();

                switch (color)
                {
                    case 9:
                        col = ConsoleColor.Blue;
                        break;
                    case 10:
                        col = ConsoleColor.Green;
                        break;
                    case 11:
                        col = ConsoleColor.Cyan;
                        break;
                    case 12:
                        col = ConsoleColor.Red;
                        break;
                    case 13:
                        col = ConsoleColor.Magenta;
                        break;
                    case 14:
                        col = ConsoleColor.Yellow;
                        break;

                    default:
                        col = ConsoleColor.Black;
                        break;
                }
                Console.ForegroundColor = col;
                Console.WriteLine("{0}", str);
                Console.ResetColor();
            }
        }
    }
}
