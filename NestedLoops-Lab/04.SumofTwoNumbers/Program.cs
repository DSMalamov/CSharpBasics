using System;

namespace _04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            bool xyxy = true;

            for (int first = start; first <= end; first++)
            {
              
                for (int second = start; second <= end ; second++)
                {
                    combinations++;
                    if (first + second == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinations} ({first} + {second} = {magicNumber})");
                        xyxy = false;
                        break;

                    }
                }
                if (xyxy == false)
                {
                    break;
                }
            }
            if (xyxy == true)
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
            }

        }
    }
}
