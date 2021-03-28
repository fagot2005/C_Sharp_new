using System;

namespace Person_And_BankAccount
{
    class Menu
    {
        private PersonsService PersonServiceMenu { get; set; } = new PersonsService();
        private BankAccountService BankAccountServiceMenu { get; set; } = new BankAccountService();

        public void MenuStepOne()
        {
            Console.Clear();
            Console.WriteLine("Select a menu item to work with the desired object:");
            Console.WriteLine("1 - Work with clients");
            Console.WriteLine("2 - Work with bankaccound");
            Console.WriteLine("Any other key - Exit");
            string firstStepMenu = Console.ReadLine();
            switch (firstStepMenu)
            {
                case "1":
                    MenuStepTwoPerson();
                    break;
                case "2":
                    MenuStepTwoBankAccount();
                    break;
                default:
                    break;
            }
        }

        public void MenuStepTwoPerson()
        {
            Console.Clear();
            Console.WriteLine("Select the menu item for working with clients:");
            Console.WriteLine("1 - Add new client");
            Console.WriteLine("2 - Find client by ID");
            Console.WriteLine("3 - Find client by name");
            Console.WriteLine("4 - Output all of clients");
            Console.WriteLine("5 - Return to previous menu");
            string twoStepMenuPerson = Console.ReadLine();
            switch (twoStepMenuPerson)
            {
                case "1":
                    PersonServiceMenu.AddNewPerson();
                    MenuStepTwoPerson();
                    break;
                case "2":
                    Console.WriteLine("Enter ID client");
                    string personID = Console.ReadLine();
                    PersonServiceMenu.FindPersonById(personID);
                    MenuStepTwoPerson();
                    break;
                case "3":
                    Console.WriteLine("Enter name of client");
                    string personName = Console.ReadLine();
                    PersonServiceMenu.FindPersonByName(personName);
                    MenuStepTwoPerson();
                    break;
                case "4":
                    PersonServiceMenu.FindAllPersons();
                    MenuStepTwoPerson();
                    break;
                case "5":
                    MenuStepOne();
                    break;
                default:
                    Console.WriteLine("You should choose an option 1, 2, 3 or 4");
                    break;
            }
        }
        public void MenuStepTwoBankAccount()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с банковскими счетами клиентов:");
            Console.WriteLine("1 - Добавление нового счета клиента");
            Console.WriteLine("2 - Увеличение остатка по счету");
            Console.WriteLine("3 - Вывести все счета всех клиентов");
            Console.WriteLine("4 - Вернуться в предыдущее меню");
            string twoStepMetuBankAccount = Console.ReadLine();
            switch (twoStepMetuBankAccount)
            {
                case "1":
                    Console.WriteLine("Enter ID client");
                    string personID = Console.ReadLine();
                    BankAccountServiceMenu.AddNewBankAccount(PersonServiceMenu.FindPersonById(personID));
                    MenuStepTwoBankAccount();
                    break;
                case "2":
                    Console.WriteLine("Enter ID bank account");
                    string bankAccountID = Console.ReadLine();
                    Console.WriteLine("Enter balance top-up amount");
                    double topUpAmount = double.Parse(Console.ReadLine());
                    BankAccountServiceMenu.TopUpAmount(bankAccountID, topUpAmount);
                    MenuStepTwoBankAccount();
                    break;
                case "3":
                    BankAccountServiceMenu.OutputAllPersonsAndAllBankAccounts();
                    MenuStepTwoBankAccount();
                    break;
                case "4":
                    MenuStepOne();
                    break;
                default:
                    Console.WriteLine("You should choose an option 1, 2, 3 or 4");
                    break;
            }
        }

        public void AddElement()
        {
            PersonServiceMenu.AddAllPersons();
            BankAccountServiceMenu.AddAllBankAccountc(PersonServiceMenu.FindPersonById("123"));
            BankAccountServiceMenu.AddAllBankAccountc(PersonServiceMenu.FindPersonById("222"));
            BankAccountServiceMenu.AddAllBankAccountc(PersonServiceMenu.FindPersonById("333"));
            BankAccountServiceMenu.AddAllBankAccountc(PersonServiceMenu.FindPersonById("444"));
        }
    }
}
