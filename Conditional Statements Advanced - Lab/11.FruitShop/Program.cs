using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double kolichestwo = double.Parse(Console.ReadLine());
            double tprice = 0;



            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {


                switch (fruit)
                {
                    case "banana":
                        tprice = kolichestwo * 2.50;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "apple":
                        tprice = kolichestwo * 1.20;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "orange":
                        tprice = kolichestwo * 0.85;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "grapefruit":
                        tprice = kolichestwo * 1.45;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "kiwi":
                        tprice = kolichestwo * 2.70;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "pineapple":
                        tprice = kolichestwo * 5.50;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "grapes":
                        tprice = kolichestwo * 3.85;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        tprice = kolichestwo * 2.70;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "apple":
                        tprice = kolichestwo * 1.25;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "orange":
                        tprice = kolichestwo * 0.90;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "grapefruit":
                        tprice = kolichestwo * 1.60;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "kiwi":
                        tprice = kolichestwo * 3.00;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "pineapple":
                        tprice = kolichestwo * 5.60;
                        Console.WriteLine($"{tprice:f2}");
                        break;
                    case "grapes":
                        tprice = kolichestwo * 4.20;
                        Console.WriteLine($"{tprice:f2}");
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
