using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test[0] = new MyClass("Tom", 23.5);
            Console.WriteLine(test[0]);
        }
    }

    class Test
    {
        private MyClass[] array = new MyClass[5];

        public MyClass this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }
    }

    class MyClass
    {
        public string Name { get; set; }
        public double Summ { get; set; }

        public MyClass(string name, double summ)
        {
            Name = name;
            Summ = summ;
        }
    }
}
