using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());  
            int srok = int.Parse(Console.ReadLine());
            double lp = double.Parse(Console.ReadLine());
            double natrupanaLihva = deposit * (lp / 100);
            double lpm = natrupanaLihva / 12;
            double kraina = deposit + srok * lpm;
            Console.WriteLine(kraina);
        }
    }
}
