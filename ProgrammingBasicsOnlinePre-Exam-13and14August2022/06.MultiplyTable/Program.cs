using System;

namespace _06.MultiplyTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num % 10; i++) //324 1-4
            {
                for (int j = 1; j <= num / 10 % 10; j++) // 1-2
                {
                    for (int k = 1; k <= num / 100; k++) // 1-3
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {k*j*i};");
                    }
                }
            }
        }
    }
}
