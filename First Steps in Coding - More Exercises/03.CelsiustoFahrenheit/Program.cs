﻿using System;

namespace _03.CelsiustoFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double farenheit = celsius * 1.8 + 32;
            Console.WriteLine($"{farenheit:f2}");
        }
    }
}
