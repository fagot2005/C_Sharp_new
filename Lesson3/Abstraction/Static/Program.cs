using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(123, 2000, 0);
            bankAccount.FinalSumm = bankAccount.Summ;
            Console.WriteLine("FinalSumm = {0} USD.", bankAccount.FinalSumm);
            Console.WriteLine("FinalSumm = {0} USD.", bankAccount.FinalSumm + Rate.BalanceAtTheBeginningOfTheDay(bankAccount));


            Console.ReadKey();
        }
    }

    class BankAccount
    {
        public int ID { get; set; }
        public double Summ { get; set; }
        public double FinalSumm { get; set; }

        public BankAccount(int iD, double summ, double finalSumm)
        {
            ID = iD;
            Summ = summ;
            FinalSumm = finalSumm;
        }
    }

    static class Rate
    {
        private static double rate = 0.22;

        public static double BalanceAtTheBeginningOfTheDay(BankAccount bankAccount)
        {
            return bankAccount.FinalSumm * Rate.rate;
        }
    }
}
