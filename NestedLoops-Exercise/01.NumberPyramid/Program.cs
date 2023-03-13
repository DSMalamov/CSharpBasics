using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currnetNumber = 1;
            bool isBigger = false;

            for (int rows = 0; rows < number; rows++)
            {
                for (int col = 0; col <= rows; col++)
                {
                    if (currnetNumber > number)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{currnetNumber} ");
                    currnetNumber++;
                }

                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
