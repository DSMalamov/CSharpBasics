using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = days * 50;
                priceApartment = days * 65;

                if (days > 7 && days <= 14)
                {
                    priceStudio *= 0.95;
                }
                else if (days > 14) 
                {
                    priceStudio *= 0.70;
                    priceApartment *= 0.9;      
                }

            }
            else if (month == "June" || month == "September")
            {
                priceStudio = days * 75.20;
                priceApartment = days * 68.70;
                if (days > 14)
                {
                    priceStudio *= 0.80;
                    priceApartment *= 0.9;

                }
            }
            else if (month == "July" || month == "August")
            {
                priceStudio = days * 76;
                priceApartment = days * 77;
                if (days > 14)
                {
                    
                    priceApartment *= 0.9;

                }
            }
            Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
        }
    }
}
