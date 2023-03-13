using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int volume = height * width * length;

            string input =Console.ReadLine();

            while (true)
            {
                if (input == "Done")
                {
                    Console.WriteLine($"{volume} Cubic meters left.");
                    break;

                }
                int boxes = int.Parse(input);
                volume -= boxes;
                if (volume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    break;
                }
                input = Console.ReadLine();
            }
            
        }
    }
}
