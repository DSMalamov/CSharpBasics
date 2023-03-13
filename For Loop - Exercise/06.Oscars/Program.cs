using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double academicPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double totalPoins = academicPoints;

            for (int i = 1; i <= n; i++)
            {
                string nameOfTheJudge = Console.ReadLine();
                double pointsFromTheJudge = double.Parse((Console.ReadLine()));
                int nameJLenght = nameOfTheJudge.Length;

                totalPoins += nameJLenght * pointsFromTheJudge / 2;
                if (totalPoins > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoins:f1}!");
                    break;
                }
                if (i>=n)
                {
                    Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - totalPoins:f1} more!");
                }
            }
        }
    }
}
