﻿using System;

namespace _07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int liters = int.Parse(Console.ReadLine());

            if (fuel == "Diesel") 
            { 
                if (liters >= 25) 
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }
            }
            else if (fuel == "Gasoline")
            {
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
            }
            else if (fuel == "Gas") 
            {
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine($"Invalid fuel!");
            }
        }
    }
}
