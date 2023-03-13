using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double ppsm = 7.61;
            double pwd = area * ppsm;
            double discount = pwd * 0.18;
            double fp = pwd - discount;
            Console.WriteLine($"The final price is:{fp}");
            Console.WriteLine($"The discount is: {discount}");
        }
    }
}
