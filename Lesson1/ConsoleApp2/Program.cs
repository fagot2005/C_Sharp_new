using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ligthArray = 1000;
            List<int> list = new List<int>() { 1, 2, 3 };
            for (int i = 5; i < ligthArray; i = i + 2)
            {
                bool emptyNumger = true;
                for (int j = 3; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        emptyNumger = false;
                        break;
                    }
                }
                if (emptyNumger)
                    list.Add(i);
            }
            foreach (int o in list)
            {
                Console.WriteLine(string.Format("{0} - {1}", o, o * o));
            }
            Console.ReadKey();
        }
    }
}
