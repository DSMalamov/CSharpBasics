using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int pieces = width * lenght;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    Console.WriteLine($"{pieces} pieces are left.");    
                    break;
                }
                int piecesP = int.Parse(input);
                pieces -= piecesP;
                if (pieces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
                    break;
                }
            }
        }
    }
}
