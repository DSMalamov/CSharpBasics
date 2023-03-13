using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());
            int points = startingPoints;
            int wins = 0;
            for (int i = 1; i <= tournaments; i++)
            {
                string etap = Console.ReadLine();

                switch (etap)
                {
                    case "W":
                        points += 2000;
                        wins++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;

                }

            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor((points * 1.0 - startingPoints) / tournaments)}");
            Console.WriteLine($"{wins * 1.0 / tournaments * 100:f2}%");
        }
    }
}
