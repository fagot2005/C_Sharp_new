using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1, b = 0;
                int c = a / b;
            }
            catch (Exception e)
            {
                e.Message("kfgdlkfgldkgdf");
                Console.WriteLine(e.Message);
            }


        }
    }
}
