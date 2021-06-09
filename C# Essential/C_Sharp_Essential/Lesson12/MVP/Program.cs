using System;

namespace MVP
{
    public delegate void MyDelegate(string str);

    class Program
    {
        public static event MyDelegate Event;

        static void Main(string[] args)
        {
            new Presenter();
            string str = "";
            while (true)
            {
                str = Console.ReadLine();
                if (!string.IsNullOrEmpty(str))
                {
                    Event.Invoke(str);
                }
            }

        }
    }
}
