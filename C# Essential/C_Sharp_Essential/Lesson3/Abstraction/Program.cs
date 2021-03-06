using System;
using System.Collections.Generic;

namespace Abstraction
{

    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:  
    //Создайте класс AbstractHandler.
    //В теле класса создать методы void Open(), void Create(), void Chenge(), void Save(). 

    //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.

    //Написать программу, которая будет выполнять определение документа и для каждого формата должны быть
    //методы открытия, создания, редактирования, сохранения определенного формата документа.  


    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler> list = new List<AbstractHandler>();
            list.Add(new XMLHandler());
            list.Add(new TXTHandler());
            list.Add(new DOCHandler());
            foreach (AbstractHandler element in list)
            {
                element.Open();
                element.Create();
                element.Chenge();
                element.Save();
                Console.WriteLine("Type document {0}", element.GetType().Name.Substring(0, 3));
                Console.WriteLine(new string('-', 50));
            }
            Console.ReadKey();
        }
    }

    abstract class AbstractHandler
    {
        public virtual void Open()
        {
            Console.WriteLine("Metod Save not override for class");
        }
        public virtual void Create()
        {
            Console.WriteLine("Metod Save not override for class");
        }
        public virtual void Chenge()
        {
            Console.WriteLine("Metod Save not override for class");
        }
        public virtual void Save()
        {
            Console.WriteLine("Metod Save not override for class");
        }
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");
        }

        public override void Chenge()
        {
            Console.WriteLine("Chenge XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Chenge()
        {
            Console.WriteLine("Chenge TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void Chenge()
        {
            Console.WriteLine("Chenge DOC");
        }

        //public override void Save()
        //{
        //    Console.WriteLine("Save DOC");
        //}
    }
}
