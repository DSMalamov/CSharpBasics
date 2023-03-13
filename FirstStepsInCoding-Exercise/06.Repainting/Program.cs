using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double pnylon = 1.50;
            double ppaint = 14.50 ;
            double prazreditel = 5.00 * razreditel;
            double bag = 0.40;
            double fpnylon = (nylon + 2) * pnylon;
            double fppaint = (paint + paint * 0.1) * ppaint;
            double pfproducts = fpnylon + fppaint + bag + prazreditel;
            double pwork = (pfproducts * 0.30) * hours;
            double fprice = pwork + pfproducts;
            Console.WriteLine( fprice );


        }
    }
}
