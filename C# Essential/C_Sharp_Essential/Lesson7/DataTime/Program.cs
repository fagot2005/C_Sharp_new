using System;

namespace DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataTime1 = new DateTime(2021, 01, 01);
            DateTime dataTime2 = DateTime.Now.Date;
            Console.WriteLine(dataTime1.Date);
            Console.WriteLine(dataTime2.Date);
            TimeSpan res = dataTime2.Date - dataTime1.Date;
            int countDays = res.Days;
            Console.WriteLine(res.Days);
            Console.ReadLine();
        }
    }
}
