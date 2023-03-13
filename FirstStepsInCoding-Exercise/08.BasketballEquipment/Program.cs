using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double shoes = tax * 0.6;
            double clothes = shoes * 0.8;
            double ball = clothes * 0.25;
            double accesoaries = ball * 0.20;
            double sum = shoes + clothes + ball + accesoaries + tax;
            Console.WriteLine(sum);
        }
    }
}
