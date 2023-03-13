using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogf = int.Parse(Console.ReadLine());
            int catf = int.Parse(Console.ReadLine());
            double dogfp = 2.50;
            int catfp = 4;
            double fp = dogf * dogfp + catf * catfp;
            Console.WriteLine($"{fp} lv.");
        }
    }
}
