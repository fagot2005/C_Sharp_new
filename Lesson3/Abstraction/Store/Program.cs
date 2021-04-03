using System;

namespace Store
{

    //    Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:  
    //Создать класс Article, содержащий следующие закрытые поля: 
    //• название товара; 
    //• название магазина, в котором продается товар; 
    //• стоимость товара в гривнах.

    //Создать класс Store, содержащий закрытый массив элементов типа Article.  
    //Обеспечить следующие возможности: 
    //• вывод информации о товаре по номеру с помощью индекса; 
    //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение; 

    //Написать программу, вывода на экран информацию о товаре.


    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine("Enter article index");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index <= 3)
                Console.WriteLine("ArticleName {0}, Store {1}, Price {2}", store[index].ArticleName, store[index].StoreName, store[index].Price);
            //Console.WriteLine("Enter article name");
            //string name = Console.ReadLine();
            //int countarticle = 0;
            //for (int i = 0; i < store.Article.Length; i++)
            //{
            //    if (String.Equals(store.Article[i].ArticleName, name))
            //    {
            //        Console.WriteLine("ArticleName {0}, Store {1}, Price {2}", store.Article[i].ArticleName, store.Article[i].StoreName, store.Article[i].Price);
            //        countarticle++;
            //        break;
            //    }
            //}
            //if (countarticle == 0)
            //    Console.WriteLine("Article with name {0} not found.", name);
            Console.ReadKey();
        }
    }

    class Store
    {
        //public Article[] Article { get; set; }

        private Article[] array = new Article[4];

        public Article this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        public Store()
        {
            array[0] = new Article("Milk", "ATB", 28.7);
            array[1] = new Article("Coca-Cola", "Novus", 19.99);
            array[2] = new Article("Borodinsky", "Cilpo", 12.80);
            array[3] = new Article("Orange", "ATB", 32.50);
            //this.Article = array;
        }
    }

    class Article
    {
        public string ArticleName { get; set; }
        public string StoreName { get; set; }
        public double Price { get; set; }

        public Article(string articleName, string storeName, double price)
        {
            ArticleName = articleName;
            StoreName = storeName;
            Price = price;
        }
    }
}
