using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= rows; i++)
            {
                int currentN = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    sumEven += currentN;
                }
                else
                {
                    sumOdd += currentN;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes\r\nSum = {sumOdd}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(sumEven-sumOdd)}");
            }

        }
    }
}
