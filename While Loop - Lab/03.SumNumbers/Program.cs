using System;

namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int curentN = 0;
            int sum = 0;

            while (number > sum)
            {
                curentN = int.Parse(Console.ReadLine());
                sum += curentN;


            }
            Console.WriteLine(sum);
        }
    }
}
