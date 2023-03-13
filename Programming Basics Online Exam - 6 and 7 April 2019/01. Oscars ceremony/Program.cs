using System;

namespace _01._Oscars_ceremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double oscars = rent * 0.7;
            double food = oscars * 0.85;
            double sound = food / 2;

            double totalP = rent + oscars + food + sound;
            Console.WriteLine($"{totalP:f2}");
        }
    }
}
