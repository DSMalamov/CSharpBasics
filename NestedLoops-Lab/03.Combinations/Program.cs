using System;

namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int first = 0; first <= n; first++)
            {
                for (int second = 0; second <= n; second++)
                {
                    for (int third = 0; third <= n; third++)
                    {
                        if (first + second +third == n)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
