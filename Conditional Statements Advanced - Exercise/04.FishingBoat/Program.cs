using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Spring", "Summer", "Autumn", "Winter"
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermans = int.Parse(Console.ReadLine());

      
            double shipRent = 0;
           

            if (season == "Spring")
            {
                shipRent = 3000;

                if (numberOfFishermans <= 6)
                {
                    shipRent *= 0.9;
                }
                else if (numberOfFishermans > 6 && numberOfFishermans <=11)
                {
                    shipRent *= 0.85;
                }
                else if (numberOfFishermans > 12)
                {
                    shipRent *= 0.75;
                }
                if (numberOfFishermans % 2 == 0)
                {
                    shipRent *= 0.95;
                }
            }
            else if (season == "Summer")
            {
                shipRent = 4200;

                if (numberOfFishermans <= 6)
                {
                    shipRent *= 0.9;
                }
                else if (numberOfFishermans > 6 && numberOfFishermans <= 11)
                {
                    shipRent *= 0.85;
                }
                else if (numberOfFishermans > 12)
                {
                    shipRent *= 0.75;
                }
                if (numberOfFishermans % 2 == 0)
                {
                    shipRent *= 0.95;
                }
            }
            else if (season == "Autumn")
            {
                shipRent = 4200;

                if (numberOfFishermans <= 6)
                {
                    shipRent *= 0.9;
                }
                else if (numberOfFishermans > 6 && numberOfFishermans <= 11)
                {
                    shipRent *= 0.85;
                }
                else if (numberOfFishermans > 12)
                {
                    shipRent *= 0.75;
                }

            }
            else if (season == "Winter")
            {
                shipRent = 2600;

                if (numberOfFishermans <= 6)
                {
                    shipRent *= 0.9;
                }
                else if (numberOfFishermans > 6 && numberOfFishermans <= 11)
                {
                    shipRent *= 0.85;
                }
                else if (numberOfFishermans > 12)
                {
                    shipRent *= 0.75;
                }
                if (numberOfFishermans % 2 == 0)
                {
                    shipRent *= 0.95;
                }
            }

            if (groupBudget >= shipRent)
            {
                Console.WriteLine($"Yes! You have {groupBudget - shipRent:f2} leva left.");
            }
            else if (shipRent > groupBudget)
            {
                Console.WriteLine($"Not enough money! You need {shipRent - groupBudget:f2} leva.");
            }
            

        }
    }
}
