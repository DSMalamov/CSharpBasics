using System;

namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minNumber = int.MinValue;
           
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number; 
                if (number > minNumber)
                {
                    minNumber = number;
                }

            }
            int sumOfOthers = sum - minNumber;
            if (sumOfOthers == minNumber)
            {
                Console.WriteLine($"Yes\r\nSum = {minNumber}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(minNumber - sumOfOthers)}");
            }
        }
    }
}
