using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            string flowerType = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (flowerType)
            {
                case "Roses":
                    price = numberOfFlowers * 5.0;
                    if (numberOfFlowers > 80)
                    {
                        price *= 0.9;
                    }
                    break;
                case "Dahlias":
                    price = numberOfFlowers * 3.80;
                    if (numberOfFlowers > 90)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Tulips":
                    price = numberOfFlowers * 2.8;
                    if (numberOfFlowers > 80)
                    {
                        price *= 0.85;
                    }
                    break;
                case "Narcissus":
                    price = numberOfFlowers * 3.0;
                    if (numberOfFlowers < 120)
                    {
                        price *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    price = numberOfFlowers * 2.50;
                    if (numberOfFlowers < 80)
                    {
                        price *= 1.2;
                    }
                    break;
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowerType} and {budget - price:f2} leva left.");
            }
            else if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
