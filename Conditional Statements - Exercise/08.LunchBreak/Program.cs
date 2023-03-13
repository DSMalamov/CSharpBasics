using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series = Console.ReadLine();
            int seriesLenght = int.Parse(Console.ReadLine());
            int lunchBreak = int.Parse(Console.ReadLine());

            double tLunch = lunchBreak * 0.125;
            double tRest = lunchBreak * 0.25;
            double totalTime = tLunch + tRest + seriesLenght;
            if(totalTime <= lunchBreak) 
            {
                double rest = Math.Ceiling(lunchBreak - totalTime);
                Console.WriteLine($"You have enough time to watch {series} and left with {rest} minutes free time.");
            
            }
            else 
            { 
                double rest = Math.Ceiling(totalTime - lunchBreak);
                Console.WriteLine($"You don't have enough time to watch {series}, you need {rest} more minutes.");
            }


        }
    }
}
