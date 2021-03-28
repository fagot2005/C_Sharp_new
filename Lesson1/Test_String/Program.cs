using System;

namespace Test_String
{
    class Program
    {

        public class TestGendor
        {
            private string Name { get; set; }
            private Gender Gender { get; set; }

            public TestGendor(string name, Gender gender)
            {
                Name = name;
                Gender = gender;
            }
        }

        public enum Gender
        {
            Male,
            Fimale
        }

        static void Main(string[] args)
        {
            Program pr = new Program();
            Console.WriteLine("Enter name");
            string Name = Console.ReadLine();
            Gender Gender = pr.CorectInputGender();
            TestGendor tg = new TestGendor(Name, Gender);
            Console.WriteLine("Добавлен {0}, пол - {1}", Name, Gender);
            Console.ReadKey();
            //bool cont = true;
            //while (cont == true)
            //{
            //    string str = Console.ReadLine();
            //    Console.WriteLine("С клавиатуры введено {0}", str);
            //    Console.WriteLine("");
            //    Console.WriteLine("Продолжить? 1-Да, 0-Нет");
            //    string answear = Console.ReadLine();
            //    if ( String.Equals(answear, "0"))
            //        cont = false;
            //}

        }

        public Gender CorectInputGender()
        {
            Gender genderPerson = 0;
            bool corectInput = true;
            while (corectInput)
            {
                Console.Clear();
                Console.WriteLine("Enter gender, 0-Male, 1-Fimale");
                string digitGender = Console.ReadLine();
                if (String.Equals(digitGender, "0") | (String.Equals(digitGender, "1")))
                {
                    genderPerson = (Gender)int.Parse(digitGender);
                    corectInput = false;
                    //Console.WriteLine(genderPerson);
                }
                else
                {
                    Console.WriteLine("You need enter only 0 or 1. Please press any key and try again.");
                    Console.ReadKey();
                }
            }
            return genderPerson;
        }
    }
}
