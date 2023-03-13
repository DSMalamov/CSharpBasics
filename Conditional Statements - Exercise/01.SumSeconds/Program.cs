using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sumOfTime = first + second + third;
            int minutes = sumOfTime / 60;
            int seconds = sumOfTime % 60;
            if (seconds < 10) 
            {
                Console.WriteLine($"{minutes}:{seconds:d2}"); 

            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        
        }
    }
}
