﻿using System;

namespace _04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine(); 

            if (gender == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");

                }
                else if (age >= 16)
                {

                    Console.WriteLine("Mr.");
                }

            }
            if (gender == "f")
            {
                if(age < 16)
                {
                    Console.WriteLine("Miss");

                }
                else if (age >= 16)
                {

                    Console.WriteLine("Ms.");
                }

            }
        }
    }
}
