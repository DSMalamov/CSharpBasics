﻿using System;

namespace _03.AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {

                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "snake":
                case "tortoise":
                case "crocodile":
                    Console.WriteLine("reptile");
                    break ;
                default:
                    Console.WriteLine("unknown");
                    break ;

            }
        }
    }
}
