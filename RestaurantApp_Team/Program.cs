using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team
{
    //เอาไว้ใน Namespace
    class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }
    }

    internal class Program
    {
        static List<Restaurant> restaurants = new List<Restaurant>
    {
        new Restaurant { Name = "KFC", Type = "Fast Food", Rating = 4.2 },
        new Restaurant { Name = "MK", Type = "Suki", Rating = 4.7 },
        new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 },
        new Restaurant { Name = "Mala", Type = "Chinese Fod", Rating = 4.0 },
        new Restaurant { Name = "Chicken 5 Star", Type = "Grill Chicken", Rating = 4.7 },
        new Restaurant { Name = "Gareepup", Type = "Food", Rating = 4.8 }
    };

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===== Restaurant Menu =====");
                Console.WriteLine("1. Add Restaurant");
                Console.WriteLine("2. Show Good Rating");
                Console.WriteLine("3. Show Summary");
                Console.WriteLine("0. Exit");
                Console.Write("Select Menu: ");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        AddRestaurant();
                        break;
                    case "2":
                        ShowGoodRating();
                        break;
                    case "3":
                        ShowSummary();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid Menu");
                        break;
                }
            }
        }

        // คน A รับผิดชอบ
        static void AddRestaurant()
        {
            double Rating;
            Console.Write("Restaurant name : ");
            String name = Console.ReadLine();
            Console.Write("Restaurant Type : ");
            String Type = Console.ReadLine();
            Console.Write("Rating : ");
            Rating = double.Parse(Console.ReadLine());         
            restaurants.Add(new Restaurant
            {
                Name = name,
                Type = Type,
                Rating = Rating
            });
            foreach (var item in restaurants)
            {
                Console.WriteLine("Name: " + item.Name);
                Console.WriteLine("Type: " + item.Type);
                Console.WriteLine("Rating: " + item.Rating);
                Console.WriteLine("-------------------");
            }
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("completed");

            foreach (Restaurant r in restaurants)
            {
                if (r.Rating >= 4.5)
                {
                    Console.WriteLine("ชืื่อร้าน : "+r.Name+" คะเนน : "+ r.Rating);
                  
                }
            }
            
        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            double maxRating = restaurants.Max(x => x.Rating);
            double lowestRating = restaurants.Min(x => x.Rating);

            foreach (var item in restaurants)
            {
                if (item.Rating == maxRating)
                {
                    Console.WriteLine("Restaurant: " + item.Name);
                    Console.WriteLine("Rating: " + item.Rating);
                }
            }
            foreach (var item in restaurants)
            {
                if (item.Rating == lowestRating)
                { 
                    Console.WriteLine("Restaurant : "+item.Name);
                    Console.WriteLine("Rating : " + item.Rating);
                }
            }
        }
    }


}
