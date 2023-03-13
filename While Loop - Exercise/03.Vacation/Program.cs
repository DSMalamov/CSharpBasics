using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse (Console.ReadLine());
            double currentMoney = double.Parse (Console.ReadLine());
            int days = 0;
            int numberOfSpending = 0;   
            while (true)
            {
                string action = Console.ReadLine ();
                double price = double.Parse (Console.ReadLine());
                days++;

                if (action == "spend")
                {
                    numberOfSpending++;
                    if (price > currentMoney)
                    {
                        currentMoney = 0;
                    }
                    else
                    {
                        currentMoney -= price;
                    }
                    if (numberOfSpending >= 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{days}");
                        break;
                    }
                    
                }
                else if (action == "save")
                {
                    numberOfSpending = 0;
                    currentMoney += price;
                    if (currentMoney >= tripPrice)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        break;
                    }
                }
            }
        }
    }
}
