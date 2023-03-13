using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double pFgpu = 250;
            double tpFgpu = pFgpu * gpu;
            double pFcpu = tpFgpu * 0.35;
            double pFram = tpFgpu * 0.10;
            double tpFcpu = pFcpu * cpu;
            double tpFram = pFram * ram;
            double totalPrice = tpFgpu + tpFcpu + tpFram;

            if (gpu > cpu) 
            {
                totalPrice = totalPrice * 0.85;

            }
            if (budget >= totalPrice) 
            {
                double rest = budget - totalPrice;
                Console.WriteLine($"You have {rest:f2} leva left!");
            
            }
            else 
            {
                double rest = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {rest:f2} leva more!");
            
            }
        }
    }
}
