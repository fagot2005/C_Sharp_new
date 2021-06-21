using System;
using System.Xml.Linq;
using NameSpaceMyClass;

namespace NameSpaceProgram
{
class Program
{
        //Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом приложении.

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            Console.WriteLine(myClass.GetType());
            Console.ReadKey();
        }
    }
}
