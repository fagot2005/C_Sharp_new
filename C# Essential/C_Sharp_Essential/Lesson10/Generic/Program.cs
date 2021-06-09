using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Item<int>.FactoryMetod();
            Console.WriteLine(i.GetType().Name);
            Program p = Item<Program>.FactoryMetod();
            Console.WriteLine(p.GetType().Name);
            Console.ReadKey();
        }
    }
}
