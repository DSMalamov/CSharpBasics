using System;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double totalP1 = p1 * h;
            double totalP2 = p2 * h;
            double wPH = totalP1 + totalP2;
            double procentP1 = totalP1 / v * 100;
            double procentP2 = totalP2 / v * 100;
            double totalProc = procentP1 + procentP2;

            if (v >= wPH) 
            {
                double p11 = totalP1 / wPH * 100;
                double p12 = totalP2 / wPH * 100;


                Console.WriteLine($"The pool is {totalProc}% full. Pipe 1: {p11:f2}%. Pipe 2: {p12:f2}%."); 


            }
            else 
            {
                double ostatuk = wPH - v;

                Console.WriteLine($"For {h} hours the pool overflows with {ostatuk:f2} liters.");
            }
        }
    }
}
