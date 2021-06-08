using System;

namespace MyList
{
    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте коллекцию MyList<T>. Реализуйте в простейшем приближении возможность
    //использования ее экземпляра аналогично экземпляру класса List<T>. Минимально
    //требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления
    //элемента, индексатор для получения значения элемента по указанному индексу и свойство
    //только для чтения для получения общего количества элементов. Реализуйте возможность
    //перебора элементов коллекции в цикле foreach. 


    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(i + 1);
            }
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("In list {0} elements.", list.Count);
            list.Reset();
            Console.WriteLine("In list {0} elements.", list.Count);
            Console.ReadKey();
        }
    }
}
