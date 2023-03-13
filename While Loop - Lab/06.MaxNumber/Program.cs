using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int maxNum = int.MinValue;
            int cNum = 0;

            while (command != "Stop")
            {
                cNum = int.Parse(command);
                if (cNum > maxNum)
                {
                    maxNum = cNum;
                }
                
                
                command = Console.ReadLine();

            }
            Console.WriteLine(maxNum);
        }
    }
}
