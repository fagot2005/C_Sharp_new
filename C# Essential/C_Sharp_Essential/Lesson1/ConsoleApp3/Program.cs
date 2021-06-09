using System;

namespace ConsoleApp3
{

    class Person
    {
        public string firstName;

        public void Output()
        {
            Console.WriteLine(firstName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { firstName = "Stepan" };
            //person.firstName = "Stepan";
            person.Output();
            Console.ReadKey();
        }
    }
}
