using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double coins = Math.Floor(input * 100);
            int totalC = 0;

            while (coins > 0)
            {
                if (coins >= 200)
                {
                    totalC++;
                    coins -= 200;
                }
                else if (coins >= 100)
                {
                    totalC++;
                    coins -= 100;
                }
                else if (coins >= 50)
                {
                    totalC++;
                    coins -= 50;
                }
                else if (coins >= 20)
                {
                    totalC++;
                    coins -= 20;
                }
                else if (coins >= 10)
                {
                    totalC++;
                    coins -= 10;
                }
                else if (coins >= 5)
                {
                    totalC++;
                    coins -= 5;
                }
                else if (coins >= 2)
                {
                    totalC++;
                    coins -= 2;
                }
                else if (coins >= 1)
                {
                    totalC++;
                    coins -= 1;
                }
            }
            Console.WriteLine(totalC);
        }
    }
}
