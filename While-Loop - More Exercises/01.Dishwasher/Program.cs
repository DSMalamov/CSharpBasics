using System;

namespace _01.Dishwasher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int detergent = int.Parse(Console.ReadLine());
            int totalP = detergent * 750;
            int dish = 0; // 5ml
            int pot = 0;  // 15ml
            int i = 1;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                int numberOfThingsToBeWashed = int.Parse(input);

                if (i % 3 == 0)
                {
                    totalP -= numberOfThingsToBeWashed * 15;
                    pot += numberOfThingsToBeWashed;
                }
                else
                {
                    totalP -= numberOfThingsToBeWashed * 5;
                    dish += numberOfThingsToBeWashed;
                }
                if (totalP < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(totalP)} ml. more necessary!");
                    break;
                }
                i++;

                

            }
            if (totalP >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dish} dishes and {pot} pots were washed.");
                Console.WriteLine($"Leftover detergent {totalP} ml.");
            }
        }
    }
}
