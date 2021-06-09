using System;
using System.Collections;

namespace UserCollection
{

    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте метод, который в качестве аргумента принимает массив целых чисел и
    //возвращает коллекцию всех четных чисел массива.Для формирования коллекции используйте оператор yield. 



    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            IEnumerable res = UserCollection(array);
            foreach (var element in res)
            {
                Console.Write("{0} ", element);
            }
            Console.ReadLine();
        }

        static IEnumerable UserCollection(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                        yield return array[i];
                }
            }
            else
                yield break;
        }
    }


}
