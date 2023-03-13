using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double balance = 0;
            double money = 0;

            while (action != "NoMoreMoney")
            {
                money = double.Parse(action);

                
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");
                balance += money;
                action = Console.ReadLine();

            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
