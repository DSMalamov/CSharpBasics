using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string mark = Console.ReadLine();

            double price = 0;
            int nights = days - 1;
            double totalPrice = 0;
            

            //"room for one person", "apartment" или "president apartment"
            if (nights < 10)
            {
                switch (room)
                {
                    case "room for one person":
                        price = 18.00;
                        totalPrice = nights * price;
                        break;
                    case "apartment":
                        price = 25.00;
                        totalPrice = nights * price * 0.7;
                        break;
                    case "president apartment":
                        price = 35.00;
                        totalPrice = nights * price * 0.9;
                        break;

                }
                
            }
            else if (nights >= 10 && nights <= 15)
            {
                switch (room)
                {
                    case "room for one person":
                        price = 18.00;
                        totalPrice = nights * price;
                        break;
                    case "apartment":
                        price = 25.00;
                        totalPrice = nights * price * 0.65;
                        break;
                    case "president apartment":
                        price = 35.00;
                        totalPrice = nights * price * 0.85;
                        break;

                }

            }
            else if (nights > 15)
            {
                switch (room)
                {
                    case "room for one person":
                        price = 18.00;
                        totalPrice = nights * price;
                        break;
                    case "apartment":
                        price = 25.00;
                        totalPrice = nights * price * 0.5;
                        break;
                    case "president apartment":
                        price = 35.00;
                        totalPrice = nights * price * 0.8;
                        break;

                }
            }
            if (mark == "positive")
            {
                totalPrice *= 1.25;
            }
            else if (mark == "negative")
            {
                totalPrice *= 0.9;
            }
            Console.WriteLine($"{totalPrice:f2}");
            
        }
    }
}
