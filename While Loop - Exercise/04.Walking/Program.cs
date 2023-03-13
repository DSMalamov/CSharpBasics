using System;

namespace _04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSteps = 0;

            while (true)
            {
                if (input == "Going home")
                {
                    int steptToHome = int.Parse(Console.ReadLine());
                    totalSteps += steptToHome;
                    break;
                }
               
                int steps = int.Parse(input);
                
                totalSteps += steps;
                if (totalSteps >= 10000)
                {
                    break;
                }

                input = Console.ReadLine();
            }
            if (totalSteps < 10000)
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }

        }
    }
}
