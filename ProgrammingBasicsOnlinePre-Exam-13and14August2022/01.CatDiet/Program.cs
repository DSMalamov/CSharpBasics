using System;

namespace _01.CatDiet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fats = int.Parse(Console.ReadLine());
            int proteins = int.Parse(Console.ReadLine());
            int carbs = int.Parse(Console.ReadLine());
            int cal = int.Parse(Console.ReadLine());
            int water = int.Parse(Console.ReadLine());

            double fatsG = ((double)cal / 100 * fats) / 9;
            double protG = ((double)cal / 100 * proteins) / 4;
            double carbG = ((double)cal / 100 * carbs) / 4;

            double totalG = fatsG + protG + carbG;

            double ccalPG = cal / totalG;

            double waterPercal = 100 - water;
            double waterPerCal = ccalPG / 100 * waterPercal;
            Console.WriteLine($"{waterPerCal:f4}");
        }
    }
}
