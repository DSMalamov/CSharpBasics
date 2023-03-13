using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();
            string currentPass = Console.ReadLine();

            while (currentPass != password)
            {
                currentPass = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
