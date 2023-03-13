using System;

namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Брой магнолии – цяло число в интервала [0 … 50]
            //•	Брой зюмбюли – цяло число в интервала [0 … 50]
            //•	Брой рози – цяло число в интервала [0 … 50]
            //•	Брой кактуси – цяло число в интервала [0 … 50]
            //•	Цена на подаръка – реално число в интервала [0.00 … 500.00]

            int magnolii = int.Parse(Console.ReadLine());
            int zyumbyul = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());

            //•	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева

            double pfMagnolii = magnolii * 3.25;
            double pfZyumbyul = zyumbyul * 4.0;
            double pfRozi = rozi * 3.5;
            double pfKaktusi = kaktusi * 8;

            double income = pfKaktusi + pfMagnolii + pfRozi + pfZyumbyul;
            double totalincome = income * 0.95;

            if (totalincome >= present) 
            { 
                double rest = Math.Floor(totalincome - present);
                Console.WriteLine($"She is left with {rest} leva.");
            }
            else 
            { 
                double nedostig = Math.Ceiling(present - totalincome);
                Console.WriteLine($"She will have to borrow {nedostig} leva.");
            }
        }
    }
}
