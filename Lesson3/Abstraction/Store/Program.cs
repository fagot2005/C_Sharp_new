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
                Console.WriteLine("ArticleName {0}, Store {1}, Price {2}", store.Article[index].ArticleName, store.Article[index].StoreName, store.Article[index].Price);
            Console.WriteLine("Enter article name");
            string name = Console.ReadLine();
            int countarticle = 0;
            for (int i = 0; i < store.Article.Length; i++)
            {
                if (String.Equals(store.Article[i].ArticleName, name))
                {
                    Console.WriteLine("ArticleName {0}, Store {1}, Price {2}", store.Article[i].ArticleName, store.Article[i].StoreName, store.Article[i].Price);
                    countarticle++;
                    break;
                }
            }
            if (countarticle == 0)
                Console.WriteLine("Article with name {0} not found.", name);
            Console.ReadKey();
        }
    }

    class Store
    {
        public Article[] Article { get; set; }

        public Store()
        {
            Article[] array = new Article[4];
            Article milk = new Article("Milk", "ATB", 28.7);
            Article cola = new Article("Coca-Cola", "Novus", 19.99);
            Article bread = new Article("Borodinsky", "Cilpo", 12.80);
            Article orange = new Article("Orange", "ATB", 32.50);
            array[0] = milk;
            array[1] = cola;
            array[2] = bread;
            array[3] = orange;
            this.Article = array;
        }
    }

    class Article
    {
        private string articleName;
        private string storeName;
        private double price;

        public Article(string articleName, string storeName, double price)
        {
            ArticleName = articleName;
            StoreName = storeName;
            Price = price;
        }

        public string ArticleName { get => articleName; set => articleName = value; }
        public string StoreName { get => storeName; set => storeName = value; }
        public double Price { get => price; set => price = value; }
    }
}
