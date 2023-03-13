using System;

namespace _02._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceClothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double pStatist = statists * priceClothes;

            if (statists > 150)
            {
                pStatist *= 0.9;
            }

            double totalPrice = pStatist + decor;

            if (totalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:f2} leva left.");
            }
        }
    }
}
