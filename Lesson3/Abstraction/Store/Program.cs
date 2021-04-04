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
            if (store[index] != null)
                Console.WriteLine("ArticleName {0}, Store {1}, Price {2}", store[index].ArticleName, store[index].StoreName, store[index].Price);
            else Console.WriteLine("Index {0} does not exist", index);
            Console.WriteLine("Enter article name");
            string name = Console.ReadLine();
            if (store[name] != null)
                Console.WriteLine("ArticleName {0}, Store {1}, Price {2}", store[name].ArticleName, store[name].StoreName, store[name].Price);
            else Console.WriteLine("Article with name {0} not found.", name);
            Console.ReadKey();
        }
    }

    class Store
    {
        //public Article[] Article { get; set; }

        private Article[] array = new Article[5];

        public Article this[int index]
        {
            get
            {
                if (index <= 4 & index >= 0)
                    return array[index];
                else return null;
            }
            set
            {
                array[index] = value;
            }
        }

        public Article this[string name]
        {
            get
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (String.Equals(array[i].ArticleName, name))
                    {
                        return array[i];
                    }
                }
                return null;
            }
        }

        public Store()
        {
            array[0] = new Article("Milk", "ATB", 28.7);
            array[4] = new Article("Milk", "Novus", 34.7);
            array[1] = new Article("Coca-Cola", "Novus", 19.99);
            array[2] = new Article("Borodinsky", "Cilpo", 12.80);
            array[3] = new Article("Orange", "ATB", 32.50);
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
