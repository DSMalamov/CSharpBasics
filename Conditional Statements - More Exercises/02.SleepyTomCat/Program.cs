using System;

namespace _02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int workingD = 365 - daysOff;
            int timeWD = workingD * 63;
            int timeDOff = daysOff * 127;
            int totalT = timeWD + timeDOff;
            

            if (totalT > 30000) 
            {
                double ostatuk1 = totalT - 30000;
                double hours = Math.Floor(ostatuk1 / 60);
                double mins = ostatuk1 % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {mins} minutes more for play");
            }
            else 
            {
                double ostatuk = 30000 - totalT;
                double hours = Math.Floor(ostatuk / 60);
                double mins = ostatuk % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {mins} minutes less for play");
                
            }
        }
    }
}
