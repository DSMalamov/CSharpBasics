using System;

namespace _05.AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cycles = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < cycles; i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine($"{sum/cycles:f2}");
        }
    }
}
