using System;

namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double razhod = 0;
            double yearsOfIvan = 18;
            for (int i = 1800; i <= year; i++)
            {
                

                if (i % 2 == 0)
                {
                    razhod += 12000;
                }
                else
                {
                    razhod += 12000 + 50 * yearsOfIvan;
                }
                yearsOfIvan++;


            }
            if (razhod <= heritage)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage - razhod:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {razhod - heritage:f2} dollars to survive.");
            }
        }
    }
}
