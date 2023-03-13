using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double totalSaveings = 0;

            while (destination != "End")
            {
                
                while (totalSaveings< budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    totalSaveings += money;
                   
                }
                Console.WriteLine($"Going to {destination}!");
                totalSaveings = 0;
                destination = Console.ReadLine();
                budget = double.Parse(Console.ReadLine());

            }
        }
    }
}
