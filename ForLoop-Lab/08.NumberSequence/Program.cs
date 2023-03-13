using System;

namespace _08.NumberSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxN = int.MinValue;
            int minN = int.MaxValue;

            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                int cNum = int.Parse(Console.ReadLine());

                if (cNum > maxN)
                {
                    maxN = cNum;
                }

                if (cNum < minN) 
                {
                    minN = cNum;
                }
            }
            Console.WriteLine($"Max number: {maxN}");
            Console.WriteLine($"Min number: {minN}");



        }
    }
}
