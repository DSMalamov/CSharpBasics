using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapepersqm = double.Parse(Console.ReadLine());
            int litersw = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            
            double procotrekolta = area * 0.4;
            double kilograpes = procotrekolta * grapepersqm;
            double literwine = kilograpes / 2.5;

            if (literwine < litersw) 
            {
                double nedostig = Math.Floor(litersw - literwine);

                Console.WriteLine($"It will be a tough winter! More {nedostig} liters wine needed.");
            
            }
            else 
            {

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(literwine)} liters.");
                double morewine = Math.Ceiling(literwine - litersw);
                double wpp = Math.Ceiling(morewine / workers);
                Console.WriteLine($"{morewine} liters left -> {wpp} liters per person.");
            
            }

        }
    }
}
