using System;

namespace _05.SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int WBC = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double ppp = 5.80 * pens;
            double ppm = 7.20 * markers;
            double preparat = 1.20 * WBC;
            double discountp = (discount/100);
            double cenabn = ppp + ppm + preparat;
            Console.WriteLine(cenabn - (cenabn * discountp);

        }
    }
}
