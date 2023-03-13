using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double prTrip = double.Parse(Console.ReadLine());
            int nPuzzles = int.Parse(Console.ReadLine());
            int nDolls = int.Parse(Console.ReadLine());
            int nBears = int.Parse(Console.ReadLine());
            int nMinios = int.Parse(Console.ReadLine());
            int nTrucks = int.Parse(Console.ReadLine());

            int sumOfToys = nPuzzles + nDolls + nBears + nMinios + nTrucks;

            double pfPuzzles = nPuzzles * 2.60;
            double pfDolls = nDolls * 3.0;
            double pfBears = nBears * 4.1;
            double pfMinions = nMinios * 8.2;
            double pfTrucks = nTrucks * 2.0;

            double SumOfPr = pfPuzzles + pfDolls + pfBears + pfMinions + pfTrucks;
            

            if (sumOfToys >= 50) 
            {
                SumOfPr = SumOfPr * 0.75;

            }
            double rent = SumOfPr * 0.1;
            double totalSumOfPr = SumOfPr - rent;

            if (totalSumOfPr >= prTrip) 
            {
                double income = totalSumOfPr - prTrip;
                Console.WriteLine($"Yes! {income:F2} lv left.");
            }
            else 
            {
                double income = prTrip - totalSumOfPr;
                Console.WriteLine($"Not enough money! {income:F2} lv needed.");
            }
        }
    }
}
