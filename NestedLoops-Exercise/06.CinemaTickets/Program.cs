using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int totalT = 0;
            int numberST = 0;
            int numberKT = 0;
            int numberSTT = 0;

            while (movie != "Finish")
            {
                int seats =int.Parse(Console.ReadLine());
               
                int totalTFM = 0;

                for (int i = 0; i < seats; i++)
                {
                    string type = Console.ReadLine();

                    if (type == "End")
                    {
                        break;

                    }
                    else if (type == "student")
                    {
                        numberSTT++;
                        totalTFM++;
                    }
                    else if (type == "standard")
                    {
                        numberST++;
                        totalTFM++;
                    }
                    else if (type == "kid")
                    {
                        numberKT++;
                        totalTFM++;
                    }

                }
                
                totalT += totalTFM;
                double avarage = (double)totalTFM / seats * 100;
                Console.WriteLine($"{movie} - {avarage:f2}% full.");

                movie = Console.ReadLine();

            }
            
            Console.WriteLine($"Total tickets: {totalT}");
            double avarageST = (double)numberST / totalT * 100;
            double avarageKT = (double)numberKT / totalT * 100;
            double avarageSTT = (double)numberSTT / totalT * 100;
            Console.WriteLine($"{avarageSTT:f2}% student tickets.");
            Console.WriteLine($"{avarageST:f2}% standard tickets.");
            Console.WriteLine($"{avarageKT:f2}% kids tickets.");

            
        }
    }
}
