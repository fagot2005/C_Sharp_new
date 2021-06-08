using System;
using System.Collections.Generic;

namespace Worker
{
    class Program
    {
        //          Требуется: Описать структуру с именем Worker, содержащую следующие поля:  
        //• фамилия и инициалы работника;  
        //• название занимаемой должности;  
        //• год поступления на работу.
        //          Написать программу, выполняющую следующие действия:  
        //• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены по алфавиту);  
        //• если значение года введено не в соответствующем формате выдает исключение.
        //• вывод на экран фамилии работника, стаж работы которого превышает введенное значение.  


        static void Main(string[] args)
        {
            List<Worker> list = new List<Worker>(5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Name.");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Post.");
                string post = Console.ReadLine();
                Console.WriteLine("Enter Year.");
                int year = Convert.ToInt32(Console.ReadLine());
                list.Add(new Worker(name, post, year));
            }
            Console.WriteLine("Hello World!");
        }
    }
}
