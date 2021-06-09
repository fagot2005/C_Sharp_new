using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Test
{
    class Animal
    {
        public string Tipe { get; set; }

        
        public void PrintAnimalProperty(string tipe, int countLegs)
        {
            Console.WriteLine("This {0} Animal have a {1} legs", tipe, countLegs);
        }
    }
}
