using System;

namespace _08.FuelTank_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();
            double benzin = 2.22;
            double dizel = 2.33;
            double gas = 0.93;
            if (fuel == "Gas")
            {
                if (card == "Yes")
                {
                    if (liters >= 20 && liters <= 25)
                    {
                        double otstupkaSKarta = gas - 0.08;
                        double total = otstupkaSKarta * liters * 0.92;
                        Console.WriteLine($"{total:f2} lv.");
                    }
                    else if (liters > 25)
                    {
                        double otstupkaSKarta = gas - 0.08;
                        double total = otstupkaSKarta * liters * 0.90;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else
                    {
                        double otstupkaSKart = gas - 0.08;
                        double tota = otstupkaSKart * liters;
                        Console.WriteLine($"{tota:F2} lv.");
                    }
                }
                else if (card == "No")
                {
                    if (liters >= 20 && liters <= 25)
                    {
                        double total = gas * liters * 0.92;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else if (liters > 25)
                    {
                        double total = gas * liters * 0.90;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else
                    {
                        double tota = gas * liters;
                        Console.WriteLine($"{tota:F2} lv.");
                    }
                }
            }
            else if (fuel == "Gasoline")
            {
                if (card == "Yes")
                {
                    if (liters >= 20 && liters <= 25)
                    {
                        double otstupkaSKarta = benzin - 0.18;
                        double total = otstupkaSKarta * liters * 0.92;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else if (liters > 25)
                    {
                        double otstupkaSKarta = benzin - 0.18;
                        double total = otstupkaSKarta * liters * 0.90;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else
                    {
                        double otstupkaSKart = benzin - 0.18;
                        double tota = otstupkaSKart * liters;
                        Console.WriteLine($"{tota:F2} lv.");
                    }
                }
                else if (card == "No")
                {
                    if (liters >= 20 && liters <= 25)
                    {
                        double total = benzin * liters * 0.92;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else if (liters > 25)
                    {
                        double total = benzin * liters * 0.90;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else
                    {
                        double tota = benzin * liters;
                        Console.WriteLine($"{tota:F2} lv.");
                    }

                }
            }
            else if (fuel == "Diesel")
            {
                if (card == "Yes")
                {
                    if (liters >= 20 && liters <= 25)
                    {
                        double otstupkaSKarta = dizel - 0.12;
                        double total = otstupkaSKarta * liters * 0.92;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else if (liters > 25)
                    {
                        double otstupkaSKarta = dizel - 0.12;
                        double total = otstupkaSKarta * liters * 0.90;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else
                    {
                        double otstupkaSKart = dizel - 0.12;
                        double tota = otstupkaSKart * liters;
                        Console.WriteLine($"{tota:F2} lv.");
                    }
                }
                else if (card == "No")
                {
                    if (liters >= 20 && liters <= 25)
                    {
                        double total = dizel * liters * 0.92;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else if (liters > 25)
                    {
                        double total = dizel * liters * 0.90;
                        Console.WriteLine($"{total:F2} lv.");
                    }
                    else
                    {
                        double tota = dizel * liters;
                        Console.WriteLine($"{tota:f2} lv.");
                    }
                }
            }
        }
    }
}
