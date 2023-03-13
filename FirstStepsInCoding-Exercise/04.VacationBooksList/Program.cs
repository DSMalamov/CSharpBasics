using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brStranici = int.Parse(Console.ReadLine());
            int sph = int.Parse(Console.ReadLine());
            int brDni = int.Parse(Console.ReadLine());
            int timeForOneBook = brStranici / sph;
            Console.WriteLine(timeForOneBook / brDni);


        }
    }
}
