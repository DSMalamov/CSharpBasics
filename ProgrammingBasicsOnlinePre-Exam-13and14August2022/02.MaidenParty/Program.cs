using System;

namespace _02.MaidenParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maidenPartyPrice = double.Parse(Console.ReadLine());
            int loveLetter = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int keyHolders = int.Parse(Console.ReadLine());
            int karikaturi = int.Parse(Console.ReadLine());
            int surprises = int.Parse(Console.ReadLine());

            double plLoveLetter = loveLetter * 0.6;
            double pRoses = roses * 7.2;
            double pKeyHolders = keyHolders * 3.6;
            double Pkarikaturi = karikaturi * 18.20;
            double pSurprises = surprises * 22.0;

            double totalP = pKeyHolders + plLoveLetter + pRoses + Pkarikaturi + pSurprises;
            int totalT = loveLetter + roses + keyHolders + karikaturi + surprises;

            if (totalT >= 25)
            {
                totalP = totalP * 0.65;
            }

            double income = totalP * 0.9;
            if (income >= maidenPartyPrice)
            {
                Console.WriteLine($"Yes! {(income - maidenPartyPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(maidenPartyPrice - income):f2} lv needed.");
            }
        }
    }
}
