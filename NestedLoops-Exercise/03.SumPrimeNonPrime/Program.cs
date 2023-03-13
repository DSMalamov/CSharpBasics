using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int prime = 0;
            int nonPrime = 0;

            while (input != "stop")
            {
                int curentN = int.Parse(input);
                int counter = 0;

                if (curentN < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                else if (curentN == 0) 
                {
                    input = Console.ReadLine();
                    continue;

                }

                for (int i = 1; i <= curentN; i++)
                {
                    if (curentN % i == 0)
                    {
                        counter++;
                    }
                    
                }

                if (counter == 2)
                {
                    prime += curentN;
                }
                else
                {
                    nonPrime += curentN;
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");

        }
    }
}
