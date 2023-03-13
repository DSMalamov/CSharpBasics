using System;

namespace _03.Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            int numberOfCargos = int.Parse(Console.ReadLine());
            //•	До 3 тона – микробус(200 лева на тон)
            //•	От 4 до 11 тона – камион(175 лева на тон)
            //•	12 и повече тона – влак(120 лева на тон)
            int totalTonage = 0;
            double cargoVan = 0;
            double cargoTruck = 0;
            double cargoTrain = 0;
            double totalPrice = 0;
            
            for (int i = 0; i < numberOfCargos; i++)
            {
                int input = int.Parse(Console.ReadLine());
                totalTonage += input;

                if (input <= 3)
                {
                    totalPrice += input * 200;
                    cargoVan += input;
                }
                else if (input <= 11)
                {
                    totalPrice += input * 175;
                    cargoTruck += input;
                }
                else if (input > 11)
                {
                    totalPrice += input * 120;
                    cargoTrain += input;
                }
            }

            Console.WriteLine($"{totalPrice / totalTonage:f2}");
            Console.WriteLine($"{100 * 1.0 / totalTonage * cargoVan:f2}%");
            Console.WriteLine($"{100 * 1.0 / totalTonage * cargoTruck:f2}%");
            Console.WriteLine($"{100 * 1.0 / totalTonage * cargoTrain:f2}%");

        }
    }
}
