using System;
using System.Linq;

namespace _017_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection cars = new CarCollection();
            BuyerCollection buyers = new BuyerCollection();

            cars.AddCar(new CarCollection.Car("Cabriolet", "Delage D6 - 70", "1938", "Black"));
            cars.AddCar("Cabriolet", "Packard Twelve Collapsible Touring","1938","Red");
            cars.AddCar("Mercedes-Benz", "Formula Racing Car", "1939", "Grey");
            cars.AddCar("Ford", "Deluxe Station Wagon", "1940", "Black-Brown");
            cars.AddCar("Cadillac", "Sixty-Two Coupe", "1941", "Green");
            cars.AddCar("Packard", "160 Panel Brougham by Rollston", "1941", "Black");

            buyers.Add("Formula Racing Car", "Bogach", "100");
            buyers.Add("Deluxe Station Wagon", "Bogach 2", "200");

            Console.WriteLine("Коллекция автомобилей : ");
            Console.WriteLine(new string('_',30));
            var car_collection = from CarCollection.Car car in cars
                                 group car by car.year;
                                 

            foreach (var item in car_collection)
            {
                Console.WriteLine("Goup [{0}]",item.Key);
                foreach (var car in item)
                {
                    Console.WriteLine(car);
                }
                Console.WriteLine(new string('_',30));
            }

            Console.WriteLine();
            Console.WriteLine("Покупатели :");
            Console.WriteLine(new string('_', 30));

            var buyer_collection = from buyer in buyers
                                   select new { name = buyer.Name };

            foreach (var item in buyer_collection)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine(new string('_', 30));

            Console.WriteLine();
            Console.WriteLine("Полная информация о покупке авто :");
            Console.WriteLine(new string('_', 30));

            var full_info = from buyer in buyers
                            join car in cars
                            on buyer.CarModel equals car.model
                            select new
                            {
                                _buyer = "name : " + buyer.Name + " | phone : " + buyer.PhoneNumber,
                                _car = car.ToString()
                            };

            foreach (var item in full_info)
            {
                Console.WriteLine("[Покупатель] {0} | [Авто] {1}",item._buyer,item._car);
            }

            Console.WriteLine(new string('_', 30));
            Console.WriteLine("Наконееееееец! Задание выполнено!");

            Console.ReadKey();
        }
    }
}
