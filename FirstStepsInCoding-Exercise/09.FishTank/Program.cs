using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double ppercent = percent / 100;
            double v = a * b * h;
            double vfinal = v * (1 - ppercent);
            double liters = vfinal * 0.001;
            Console.WriteLine(liters);


        }
    }
}
