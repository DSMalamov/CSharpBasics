using System;

namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currentN = 1;

            while (currentN <= num)
            {
                Console.WriteLine(currentN);
                currentN = currentN * 2 + 1;
               
            }
        }
    }
}
