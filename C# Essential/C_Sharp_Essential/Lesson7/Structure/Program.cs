using System;

namespace Accauntant
{
    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте перечисление, в котором будут содержаться должности сотрудников как имена констант.
    //Присвойте каждой константе значение, задающее количество часов, которые должен отработать сотрудник за месяц.
    //
    //Создайте класс  Accauntant с методом bool AskForBonus(Post worker, int hours), отражающее давать или нет сотруднику
    //премию. Если сотрудник отработал больше положеных часов в месяц, то ему положена премия. 


    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();
            Post sidorov = new Post("Sidorov", Position.Middle);
            Post petrov = new Post("Petrov", Position.Senior);
            Post ivanov = new Post("Ivanov", Position.Middle);
            Post sviridov = new Post("Sviridov", Position.Junior);
            Post rebrov = new Post("Rebrov", Position.Middle);
            accauntant.AskForBonus(sidorov, 160);
            accauntant.AskForBonus(petrov, 80);
            accauntant.AskForBonus(ivanov, 120);
            accauntant.AskForBonus(sviridov, 30);
            accauntant.AskForBonus(rebrov, 95);
        }
    }

    class Post
    {
        public string name;
        public Position namePost;

        public Post(string name, Position namePost)
        {
            this.name = name;
            this.namePost = namePost;
        }
    }

    class Accauntant
    {
        public void AskForBonus(Post worker, int hours)
        {
            if (hours > (int)worker.namePost)
                Console.WriteLine("{0} awarded a prize, worked {1} hours at norm {2} hours.", worker.name, hours, (int)worker.namePost);
            else
                Console.WriteLine("{0} not awarded a prize, worked {1} hours at norm {2} hours.", worker.name, hours, (int)worker.namePost);
        }
    }

    enum Position
    {
        Junior = 50,
        Middle = 100,
        Senior = 150
    }
}
