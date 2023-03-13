using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double washingM = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            double cash = 0;
            int toys = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    cash += (toys * 10) - 1;
                }
                else
                {
                    toys++;
                }

            }
            double incomeFromToys = toys * pricePerToy;
            double totalIncome = incomeFromToys + cash;

            if (totalIncome >= washingM)
            {
                Console.WriteLine($"Yes! {totalIncome - washingM:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingM - totalIncome:f2}");
            }

            
        }
    }
}
