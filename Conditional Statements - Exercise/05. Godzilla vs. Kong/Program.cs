using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double priceForClothesPerStatist = double.Parse(Console.ReadLine());

            double dekor = budget * 0.1;
            double totalPriceFClothes = statisti * priceForClothesPerStatist;

            if (statisti >= 150)
            {
                totalPriceFClothes = totalPriceFClothes * 0.9;

            }

            double totalPrice = totalPriceFClothes + dekor;

            if(totalPrice > budget) 
            {
                double sum = totalPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {sum:f2} leva more.");
            }
            else 
            { 
                double sum = budget - totalPrice;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {sum:F2} leva left.");
            }
        }
    }
}
