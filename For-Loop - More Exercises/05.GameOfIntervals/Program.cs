using System;

namespace _05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int turns = int.Parse(Console.ReadLine());

            double points = 0;
            int to9 = 0;
            int to19 = 0;
            int to29 = 0;
            int to39 = 0;
            int to50 = 0;
            int inv = 0;

            for (int i = 0; i < turns; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < 0 || input > 50)
                {
                    inv++;
                    points /= 2;
                }
                else if (input >= 0 && input <= 9)
                {
                    to9++;
                    points += input * 0.2;
                }
                else if (input >= 10 && input <= 19)
                {
                    to19++;
                    points += input * 0.3;
                }
                else if (input >= 20 && input <= 29)
                {
                    to29++;
                    points += input * 0.4;
                }
                else if (input >= 30 && input <= 39)
                {
                    to39++;
                    points += 50;
                }
                else if (input >= 40 && input <= 50)
                {
                    to50++;
                    points += 100;
                }
               
            }
            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {100 * 1.0 / turns * to9:f2}%");
            Console.WriteLine($"From 10 to 19: {100 * 1.0 / turns * to19:f2}%");
            Console.WriteLine($"From 20 to 29: {100 * 1.0 / turns * to29:f2}%");
            Console.WriteLine($"From 30 to 39: {100 * 1.0 / turns * to39:f2}%");
            Console.WriteLine($"From 40 to 50: {100 * 1.0 / turns * to50:f2}%");
            Console.WriteLine($"Invalid numbers: {100 * 1.0 / turns * inv:f2}%");
        }
    }
}
