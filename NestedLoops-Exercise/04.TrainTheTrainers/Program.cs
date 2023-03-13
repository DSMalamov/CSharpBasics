using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double sumOfmarks = 0;
            int counter = 0;

            while (presentation != "Finish")
            {
                double marks = 0;

                for (int i = 0; i < jury; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    marks += mark;
                }
                double avarage = marks / jury;
                sumOfmarks += avarage;
                Console.WriteLine($"{presentation} - {avarage:f2}.");
                counter++;
                presentation = Console.ReadLine();

            }
            double finalAvarage = sumOfmarks / counter;
            Console.WriteLine($"Student's final assessment is {finalAvarage:f2}.");

        }
    }
}
