using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //град / продукт  coffee water   beer sweets  peanuts
                //Sofia          0.50    0.80    1.20    1.45    1.60
                //Plovdiv        0.40    0.70    1.15    1.30    1.50
                //Varna          0.45    0.70    1.10    1.35    1.55
                string prod = Console.ReadLine();
                string city = Console.ReadLine();
                double qa = double.Parse(Console.ReadLine());
            double totalPrice = 0;


            if (city == "Sofia")
            {
                switch (prod)
                {
                    case "coffee":
                        totalPrice = qa * 0.50;
                        Console.WriteLine(totalPrice);
                        break;
                    case "water":
                        totalPrice = qa * 0.80;
                        Console.WriteLine(totalPrice);
                        break;
                    case "beer":
                        totalPrice = qa * 1.20;
                        Console.WriteLine(totalPrice);
                        break;
                    case "sweets":
                        totalPrice = qa * 1.45;
                        Console.WriteLine(totalPrice);
                        break;
                    case "peanuts":
                        totalPrice = qa * 1.60;
                        Console.WriteLine(totalPrice);
                        break;
                        
                }
            }
            else if (city == "Plovdiv")
            {
                switch (prod)
                {
                    case "coffee":
                        totalPrice = qa * 0.40;
                        Console.WriteLine(totalPrice);
                        break;
                    case "water":
                        totalPrice = qa * 0.70;
                        Console.WriteLine(totalPrice);
                        break;
                    case "beer":
                        totalPrice = qa * 1.15;
                        Console.WriteLine(totalPrice);
                        break;
                    case "sweets":
                        totalPrice = qa * 1.30;
                        Console.WriteLine(totalPrice);
                        break;
                    case "peanuts":
                        totalPrice = qa * 1.50;
                        Console.WriteLine(totalPrice);
                        break;

                }
            }
            else if (city == "Varna")
            {

                switch (prod)
                {
                    case "coffee":
                        totalPrice = qa * 0.45;
                        Console.WriteLine(totalPrice);
                        break;
                    case "water":
                        totalPrice = qa * 0.70;
                        Console.WriteLine(totalPrice);
                        break;
                    case "beer":
                        totalPrice = qa * 1.10;
                        Console.WriteLine(totalPrice);
                        break;
                    case "sweets":
                        totalPrice = qa * 1.35;
                        Console.WriteLine(totalPrice);
                        break;
                    case "peanuts":
                        totalPrice = qa * 1.55;
                        Console.WriteLine(totalPrice);
                        break;

                }
            }

        }
    }
}
