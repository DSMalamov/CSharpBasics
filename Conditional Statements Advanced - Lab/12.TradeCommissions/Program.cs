using System;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double commision = 0;

            if (sales >= 0 && sales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = sales * 0.05;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Varna":
                        commision = sales * 0.045;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Plovdiv":
                        commision = sales * 0.055;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = sales * 0.07;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Varna":
                        commision = sales * 0.075;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Plovdiv":
                        commision = sales * 0.08;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }

            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = sales * 0.08;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Varna":
                        commision = sales * 0.10;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Plovdiv":
                        commision = sales * 0.12;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }

            }
            else if (sales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commision = sales * 0.12;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Varna":
                        commision = sales * 0.13;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    case "Plovdiv":
                        commision = sales * 0.145;
                        Console.WriteLine($"{commision:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}

