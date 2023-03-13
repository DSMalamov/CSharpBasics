using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double resisstance = Math.Floor(distance/15);
            double additionalTime = resisstance * 12.5;

            double timeForSwim = distance * timePerMeter;
            double totalTimeForSwim = timeForSwim + additionalTime;

                if (totalTimeForSwim < record) 
                { 
                  
                     Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeForSwim:f2} seconds.");
                }
                else 
                {
                    double addtime = totalTimeForSwim - record;
                    Console.WriteLine($"No, he failed! He was {addtime:f2} seconds slower.");
                }

        }
    }
}
