using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccount
{
    class BankAccountService
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public void AddNewBankAccount(Person person)
        {
            string id;
            Currency currency;
            double balans = 0;
            Console.WriteLine("Enner ID Bank Account");
            id = Console.ReadLine();
            //Console.WriteLine("Enter Carency Bank Account");
            currency = CorectInputCurrency();
            if (person != null)
            {
                bankAccounts.Add(new BankAccount(id, person, currency, balans));
                Console.WriteLine("Bank Account {0} client {1} carency {2} with balans {3} add sussesful", id, person.Name, currency, balans);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Bank Account {0} is not add. Client isn't found.", id);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
        }

        public void TopUpAmount(string bankAccountId, double topUpAmount)
        {
            BankAccount bankAccount = FindBankAccountById(bankAccountId);
            if (bankAccount != null)
            {
                Console.WriteLine("Balans bank account {0} changed  sussesful. Current balans is {1} {2}", bankAccount.Id, bankAccount.Balans += topUpAmount, bankAccount.Currency);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Balans not changed. This  bank account {0} not found", bankAccountId);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
        }

        public BankAccount FindBankAccountById(string bankAccountId)
        {
            BankAccount bankAccount = null;
            foreach (BankAccount element in bankAccounts)
            {
                if (String.Equals(bankAccountId, element.Id))
                {
                    bankAccount = element;
                    Console.WriteLine("Bank account with Id {0} find already in the system.", element.Id);
                    Console.WriteLine("Please, press any key to continue.");
                    Console.ReadKey();
                }
            }
            return bankAccount;
        }

        public void OutputAllPersonsAndAllBankAccounts()
        {
            foreach (BankAccount element in bankAccounts)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", element.Person.Id, element.Person.Name, element.Person.Gender, element.Person.Age, element.Id, element.Currency, element.Balans);
            }
            Console.WriteLine("Please, press any key to continue.");
            Console.ReadKey();
        }

        public void AddAllBankAccountc(Person person)
        {
            bankAccounts.Add(new BankAccount("260034", person, Currency.UAH, 2500));
            bankAccounts.Add(new BankAccount("260099", person, Currency.EUR, 3500));
        }

        public Currency CorectInputCurrency()
        {
            Currency corectCurrency = 0;
            bool corectInput = true;
            while (corectInput)
            {
                Console.WriteLine("Enter сarency new Bank Account, USD - 840, EUR = 978, UAH = 980");
                string digitСurrency = Console.ReadLine();
                if (String.Equals(digitСurrency, "840") | String.Equals(digitСurrency, "978") | String.Equals(digitСurrency, "980"))
                {
                    corectCurrency = (Currency)int.Parse(digitСurrency);
                    corectInput = false;
                }
                else
                {
                    Console.WriteLine("You need enter only 840, 978 or 980. Please press any key and try again.");
                    Console.ReadKey();
                }
            }
            return corectCurrency;
        }
    }
}