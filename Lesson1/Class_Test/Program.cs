using System;

namespace Class_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.Tipe = "Dog";
            dog1.CountLegs = 4;
            dog1.PrintAnimalProperty(dog1.Tipe, dog1.CountLegs);
        }
    }
}
