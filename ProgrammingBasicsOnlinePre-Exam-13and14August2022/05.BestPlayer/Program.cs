using System;

namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string bestPlayer = string.Empty;
            int currentGoals = 0;


            while (name != "END")
            {
                int goals = int.Parse(Console.ReadLine());


                if (goals > currentGoals)
                {
                    bestPlayer = name;
                    currentGoals = goals;
                    
                }
                if (goals >= 10)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if (currentGoals >= 3)
            {
                Console.WriteLine($"He has scored {currentGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {currentGoals} goals.");
            }
        }
    }
}
