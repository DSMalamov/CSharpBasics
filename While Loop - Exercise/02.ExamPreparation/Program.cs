using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badMarks = int.Parse(Console.ReadLine());
            string exName = Console.ReadLine();
            int mistakes = 0;
            int problems = 0;
            double sum = 0;
            string lastproblem = string.Empty;

            while (exName != "Enough") 
            { 
                int mark = int.Parse(Console.ReadLine());
                problems++;
                sum += mark;
                if (mark <= 4) 
                { 
                    mistakes++;
                    if (mistakes >= badMarks)
                    {
                        Console.WriteLine($"You need a break, {mistakes} poor grades.");
                        break;
                    }
                }
                lastproblem = exName;
                exName = Console.ReadLine();
            
            }
            double avarage = sum / problems;

            if (exName == "Enough")
            {
                Console.WriteLine($"Average score: {avarage:f2}");
                Console.WriteLine($"Number of problems: {problems}");
                Console.WriteLine($"Last problem: {lastproblem}");
            }
        }
    }
}
