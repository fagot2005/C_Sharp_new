using System;

namespace Equals_HashCode
{
    class Program
    {
        //        Создайте класс Block с 4-мя полями сторон, переопределите в нем методы:  
        //        Equals – способный сравнивать блоки между собой,  
        //        ToString – возвращающий информацию о полях блока.


        static void Main(string[] args)
        {
            Block one = new Block(12, 15, 4, 9);
            Block two = new Block(4, 9, 12, 15);

            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());

            Console.WriteLine(new string(' ', 30));

            Console.WriteLine("Блок 1 равен блоку 2 = {0}", one.Equals(two));
            if (one.GetHashCode() == two.GetHashCode())
                Console.WriteLine("Периметры блоков равны между собой");
            else
                Console.WriteLine("Периметры блоков не равны между собой");


            Console.ReadKey();
        }
    }
}
