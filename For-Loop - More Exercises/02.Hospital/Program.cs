using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int total = 0;
            int pregledani = 0;
            int lekari = 7;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                total += patients;

                if (i % 3 == 0)
                {
                    lekari++;
                }
                
                if (patients >= lekari)
                {
                    pregledani += lekari;
                }
                else
                {
                    pregledani += patients;
                }

                

            }
            Console.WriteLine($"Treated patients: {pregledani}.");
            Console.WriteLine($"Untreated patients: {total - pregledani}.");
        }
    }
}
