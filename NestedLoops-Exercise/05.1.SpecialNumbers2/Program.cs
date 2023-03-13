using System;

namespace _05._1.SpecialNumbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string currentN = i.ToString();
                int counter = 0;

                for (int j = 0; j < currentN.Length; j++)
                {
                    int digit = int.Parse(currentN[j].ToString());

                    if (digit == 0)
                    {
                        continue;
                    }

                    if (n % digit == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 4)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
