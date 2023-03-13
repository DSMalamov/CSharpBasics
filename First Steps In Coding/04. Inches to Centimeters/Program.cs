using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double inch = 2.54;
            double centimeters = inch * number;
            Console.WriteLine(centimeters);
        }
    }
}
