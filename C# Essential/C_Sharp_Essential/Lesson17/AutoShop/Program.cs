using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoShop
{
    class Program
    {

        //Представьте, что вы пишите приложение для Автостанции и вам необходимо создать простую коллекцию
        //автомобилей со следующими данными: Марка автомобиля, модель, год выпуска, цвет.А также вторую коллекцию
        //с моделью автомобиля, именем покупателя и его номером телефона.Используя простейший LINQ запрос, выведите
        //на экран информацию о покупателе одного из автомобилей и полную характеристику приобретенной ними модели.


        static void Main(string[] args)
        {
            var carsList = new List<Car>
            {
                new Car ("BMV", "X3", 2015, "Gray"),
                new Car ("BMV", "X5", 2019, "Blue"),
                new Car ("BMV", "X7", 2019, "Red"),
                new Car ("AUDI", "A6", 2020, "White"),
                new Car ("AUDI", "A5", 2020, "Pink"),
                new Car ("AUDI", "A8", 2020, "Black")
            };

            var castomersList = new List<Castomer>
            {
                new Castomer ("Serg", "0956464435", "BMV", "X3"),
                new Castomer ("Ivan", "0964564435", "BMV", "X5"),
                new Castomer("Petro", "050565432", "AUDI", "A6"),
                new Castomer("Stepan", "050987432", "AUDI", "A8"),
                new Castomer("Anna", "050565432", "AUDI", "A5")
            };

            var query =
                    from castomer in castomersList
                    join auto in carsList on (castomer.Brand, castomer.Model) equals (auto.Brand, auto.Model)
                    select new
                    {
                        Name = castomer.Name,
                        Phone = castomer.Phone,
                        Brand = auto.Brand,
                        Model = auto.Model,
                        Year = auto.Year,
                        Color = auto.Color
                    };

            foreach (var element in query)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", element.Name, element.Phone, element.Brand, element.Model, element.Year, element.Color);
            }
            Console.ReadKey();
        }
    }
}
