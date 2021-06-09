using System;
using System.Collections.Generic;

namespace Person_And_BankAccount
{
    class PersonsService
    {
        List<Person> persons = new List<Person>();

        public void AddNewPerson()
        {
            string idPerson, namePerson;
            Gender gengerPerson;
            byte agePersone;
            Console.WriteLine("Enter ID new Person");
            idPerson = Console.ReadLine();
            Console.WriteLine("Enter Name new Person");
            namePerson = Console.ReadLine();
            gengerPerson = CorectInputGender();
            Console.WriteLine("Enter age new Person");
            agePersone = byte.Parse(Console.ReadLine());
            if (FindPersonById(idPerson) == null)
            {
                persons.Add(new Person(idPerson, namePerson, gengerPerson, agePersone));
                Console.WriteLine("New Person with ID {0}, Name {1}, gender {2} and age {3} add sussesfull", idPerson, namePerson, gengerPerson, agePersone);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
        }

        public Person FindPersonById(string id)
        {
            Person resaltOfFoundElement = null;
            foreach (Person element in persons)
            {
                if (String.Equals(element.Id, id))
                {
                    resaltOfFoundElement = element;
                    Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.Id, element.Name, element.Gender, element.Age);
                    Console.WriteLine("Please, press any key to continue.");
                    Console.ReadKey();
                    break;
                }
            }
            return resaltOfFoundElement;
        }

        public void FindAllPersons()
        {
            Console.Clear();
            foreach (Person element in persons)
            {
                Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3}", element.Id, element.Name, element.Gender, element.Age);
            }
            Console.WriteLine("Please, press any key to continue.");
            Console.ReadKey();
        }

        public bool FindPersonByName(string name)
        {
            bool resaltOfFoundElement = true;
            foreach (Person element in persons)
            {
                if (String.Equals(element.Name, name))
                    resaltOfFoundElement = false;
                Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.Id, element.Name, element.Gender, element.Age);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
                break;
            }
            return resaltOfFoundElement;
        }

        public Gender CorectInputGender()
        {
            Gender genderPerson = 0;
            bool corectInput = true;
            while (corectInput)
            {
                Console.WriteLine("Enter gender new Person, 0-Male, 1-Fimale");
                string digitGender = Console.ReadLine();
                if (String.Equals(digitGender, "0") | (String.Equals(digitGender, "1")))
                {
                    genderPerson = (Gender)int.Parse(digitGender);
                    corectInput = false;
                }
                else
                {
                    Console.WriteLine("You need enter only 0 or 1. Please press any key and try again.");
                    Console.ReadKey();
                }
            }
            return genderPerson;
        }

        public void AddAllPersons()
        {
            persons.Add(new Person("123", "Ivan", Gender.Male, 34));
            persons.Add(new Person("222", "Penro", Gender.Male, 25));
            persons.Add(new Person("333", "Anna", Gender.Female, 28));
            persons.Add(new Person("444", "Stepan", Gender.Male, 45));
        }
    }
}
