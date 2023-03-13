using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
           

            for (int i = n1; i <= n2 ; i++)
            {
                string currN = i.ToString();
                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < currN.Length; j++)
                {
                    int currDigit = int.Parse(currN[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
