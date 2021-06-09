using System;

namespace Person_And_BankAccount
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            //menu.AddElement();
            menu.MenuStepOne();
            Console.ReadKey();
        }
    }
}