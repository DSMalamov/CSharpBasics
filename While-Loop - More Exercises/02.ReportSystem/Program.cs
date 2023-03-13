using System;

namespace _02.ReportSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int neededincome = int.Parse(Console.ReadLine());
            int i = 0;
            int summ = 0; //sum money
            int sumc = 0; //sum card
            int pwm = 0;
            int pwc = 0;
            int totalSum = 0;

            while (true)
            {
                i++;
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                int money = int.Parse(input);

                if (i % 2 != 0)
                {
                    if (money > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        summ += money;
                        totalSum += money;
                        pwm++;
                    }
                }
                else
                {
                    if (money < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        sumc += money;
                        totalSum += money;
                        pwc++;
                    }
                }
                if (totalSum >= neededincome)
                {
                    Console.WriteLine($"Average CS: {summ * 1.0 / pwm:f2}");
                    Console.WriteLine($"Average CC: {sumc * 1.0 / pwc:f2}");
                    break;
                }
               
            }

            if (totalSum < neededincome)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
