using System;

namespace _07._Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zidar = Console.ReadLine(); 
            int projectNmber = int.Parse(Console.ReadLine());
            int projecttime = 3;
            int truept = projectNmber * projecttime;
            Console.WriteLine($"The architect {zidar} will need {truept} hours to complete {projectNmber} project/s.");


        }
    }
}
