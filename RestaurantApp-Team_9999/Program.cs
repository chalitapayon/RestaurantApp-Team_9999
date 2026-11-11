using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp_Team_9999
{
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
        new Restaurant { Name = "Fuji", Type = "Japanese", Rating = 4.8 }
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
            Console.WriteLine("Not completed");
        }

        // คน B รับผิดชอบ
        static void ShowGoodRating()
        {
            Console.WriteLine("=== ร้านอาหารคะแนนดี ===");

            int count = 0;

            foreach (Restaurant r in restaurants)
            {
                if (r.Rating >= 4.5)
                {
                    Console.WriteLine(
                        r.Name + " - " + r.Rating
                    );
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("ไม่พบร้านอาหารที่คะแนนถึง 4.5");
            }

        }

        // คน C รับผิดชอบ
        static void ShowSummary()
        {
            if (restaurants.Count == 0)
            {
                Console.WriteLine("ไม่มีข้อมูลร้านอาหาร");
                return;
            }

            Restaurant highest = restaurants[0];
            Restaurant lowest = restaurants[0];

            foreach (Restaurant r in restaurants)
            {
                if (r.Rating > highest.Rating)
                {
                    highest = r;
                }

                if (r.Rating < lowest.Rating)
                {
                    lowest = r;
                }
            }

            Console.WriteLine("=== สรุปคะแนนร้านอาหาร ===");

            Console.WriteLine(
                "คะแนนสูงสุด: " + highest.Name
                + " (" + highest.Rating + ")"
            );

            Console.WriteLine(
                "คะแนนต่ำสุด: " + lowest.Name
                + " (" + lowest.Rating + ")"
            );

        }
    }

}
