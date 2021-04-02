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
            Console.WriteLine("Hello World!");
            //Article[] array = new Article[4];
            //Article milk = new Article("Milk", "ATB", 28.7);
            //array[0] = milk;
        }
    }

    class Store
    {
        public Article[] array1 = new Article[4];
        Article milk1 = new Article("Milk", "ATB", 28.7);
        array1[0] = milk1;
        
        //Article cola = new Article("Coca-Cola", "Novus", 19.99);
        //Article bread = new Article("Borodinsky", "Cilpo", 12.80);
        //Article orange = new Article("Orange", "ATB", 32.50);
        
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
