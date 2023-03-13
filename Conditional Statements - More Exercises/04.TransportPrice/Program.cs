using System;

namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string daytime = Console.ReadLine();

            double pfbus = 0.09 * kilometers;
            double pftrain = 0.06 * kilometers;
            double pftaxid = 0.79 * kilometers + 0.70;
            double pftaxin = 0.90 * kilometers + 0.70;
            
            if (kilometers < 20) 
            { 
                if(daytime == "day") 
                {
                    Console.WriteLine($"{pftaxid:f2}");
                }
                else if (daytime == "night") 
                {
                    Console.WriteLine($"{pftaxin:f2}");
                }
            }
            else if (kilometers < 100) 
            {
                Console.WriteLine($"{pfbus:f2}");
            }
            else 
            {
                Console.WriteLine($"{pftrain:f2}");
            
            }
        }
    }
}
