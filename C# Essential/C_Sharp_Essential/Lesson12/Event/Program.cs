using System;

namespace Event
{
    public delegate void EventDelegate();

    class MyClass
    {
        public event EventDelegate MyEvent = null;

        public void InvokeEvent()
        {
            MyEvent.Invoke();
        }
    }
    class Program
    {

        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }

        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }


        static void Main(string[] args)
        {

            MyClass instanse = new MyClass();
            instanse.MyEvent += Handler1;
            instanse.MyEvent += Handler2;
            instanse.InvokeEvent();
            instanse.MyEvent -= Handler2;
            instanse.InvokeEvent();
            instanse.MyEvent += Handler2;
            instanse.MyEvent += Handler2;
            instanse.MyEvent += Handler2;
            instanse.InvokeEvent();
            Console.WriteLine("Hello World!");
        }
    }
}
