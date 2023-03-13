using System;

namespace _5.Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double totalP = 0;
            string destination = string.Empty;
            string noshtuvki = string.Empty;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    noshtuvki = "Camp";
                    totalP = budget * 0.3;
                }
                else if (season == "winter")
                {
                    noshtuvki = "Hotel";
                    totalP = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    noshtuvki = "Camp";
                    totalP = budget * 0.4;
                }
                else if (season == "winter")
                {
                    noshtuvki = "Hotel";
                    totalP = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                noshtuvki = "Hotel";
                totalP = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{noshtuvki} - {totalP:f2}");
        }
    }
}
