using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccount
{
    public class BankAccount
    {
        public string Id { get; set; }
        public Person Person { get; set; }
        public Currency Currency { get; set; }
        public double Balans { get; set; }

        public BankAccount(string id, Person persons, Currency currency, double balans)
        {
            this.Id = id;
            this.Person = persons;
            this.Currency = currency;
            this.Balans = balans;
        }
    }
    
    public enum Currency
        {
            USD = 840,
            EUR = 978,
            UAH = 980
        }
}
