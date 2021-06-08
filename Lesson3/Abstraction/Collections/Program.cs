using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollections userCollections = new UserCollections();
            foreach (Item item in userCollections)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Prise);
            }
            userCollections.Reset();
            Console.WriteLine(new string('-', 50));
            foreach (Item item in userCollections)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Id, item.Name, item.Prise);
            }
            Console.ReadKey();
        }
    }
}
