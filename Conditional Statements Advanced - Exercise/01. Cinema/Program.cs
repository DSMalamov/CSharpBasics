using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double income = 0;
            
            if (type == "Premiere")
            {
                income = r * c * 12.00;
            }
            else if (type == "Normal")
            {
                income = r * c * 7.50;
            }
            else if (type == "Discount")
            {
                income = r * c * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");


        }
    }
}
