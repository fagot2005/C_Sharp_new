using System;
using MyDictionary;

namespace Dictionary
{
    class Program
    {
        //Используя пример выполненного домашнего задания 3 из 15 урока, реализуйте
        //возможность подключения вашего пространства имен и работы с MyDictionary<TKey,
        //TValue> аналогично экземпляру класса Dictionary<TKey, TValue>. 

        static void Main(string[] args)
        {
            MyDictionary<char, string> dictionary = new MyDictionary<char, string>(3);
            dictionary.Add(0, 'a', "Эй");
            dictionary.Add(1, 'b', "Би");
            dictionary.Add(2, 'с', "Си");
            foreach (var elem in dictionary)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey();
        }
    }
}
