﻿using System;

namespace _02.RadianstoDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rads = double.Parse(Console.ReadLine());
            double degrees = rads * 180 / Math.PI;
            Console.WriteLine(degrees);

        }
    }
}
