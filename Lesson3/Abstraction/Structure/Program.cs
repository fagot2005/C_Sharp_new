using System;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStrust myStrust = new MyStrust();
            myStrust.Summ = 55;

            Console.WriteLine(myStrust.Summ);
        }
    }

    struct MyStrust
    {
        public int Summ { get; set; }
    }


}
