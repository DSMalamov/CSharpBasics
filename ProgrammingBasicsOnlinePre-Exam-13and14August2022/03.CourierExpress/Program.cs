using System;

namespace _03.CourierExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packageMass = double.Parse(Console.ReadLine());
            string typeOfShipment = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double priceForShiping = 0;

            if (typeOfShipment == "standard")
            {
                if (packageMass < 1)
                {
                    priceForShiping = distance * 3;
                }
                else if (packageMass >= 1 && packageMass < 10) 
                {
                    priceForShiping = distance * 5;
                }
                else if (packageMass >= 10 && packageMass < 40)
                {
                    priceForShiping = distance * 10;
                }
                else if (packageMass >= 40 && packageMass < 90)
                {
                    priceForShiping = distance * 15;
                }
                else if (packageMass >= 90 && packageMass <= 150)
                {
                    priceForShiping = distance * 20;

                }
            }
            else if (typeOfShipment == "express")
            {
                if (packageMass < 1)
                {
                    double priceShiping = distance * 3;
                    double addTax = 3 * 0.8;
                    double addPerKg = packageMass * addTax;
                    double addPerKm = distance * addPerKg;
                    priceForShiping = priceShiping + addPerKm;
                }
                else if (packageMass >= 1 && packageMass < 10)
                {
                    double priceShiping = distance * 5;
                    double addTax = 5 * 0.4;
                    double addPerKg = packageMass * addTax;
                    double addPerKm = distance * addPerKg;
                    priceForShiping = priceShiping + addPerKm;
                }
                else if (packageMass >= 10 && packageMass < 40)
                {
                    double priceShiping = distance * 10;
                    double addTax = 10 * 0.05;
                    double addPerKg = packageMass * addTax;
                    double addPerKm = distance * addPerKg;
                    priceForShiping = priceShiping + addPerKm;
                }
                else if (packageMass >= 40 && packageMass < 90)
                {
                    double priceShiping = distance * 15;
                    double addTax = 15 * 0.02;
                    double addPerKg = packageMass * addTax;
                    double addPerKm = distance * addPerKg;
                    priceForShiping = priceShiping + addPerKm;
                }
                else if (packageMass >= 90 && packageMass <= 150)
                {
                    double priceShiping = distance * 20;
                    double addTax = 20 * 0.01;
                    double addPerKg = packageMass * addTax;
                    double addPerKm = distance * addPerKg;
                    priceForShiping = priceShiping + addPerKm;
                }

            }
            double finalPrice = priceForShiping / 100;

            Console.WriteLine($"The delivery of your shipment with weight of {packageMass:f3} kg. would cost {finalPrice:f2} lv.");
        }
    }
}
