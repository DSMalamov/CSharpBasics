using System;

namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passT = "s3cr3t!P@ssw0rd";
                string imp = Console.ReadLine();
            if (imp == passT) 
            {
                Console.WriteLine("Welcome");
            }
            else 
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
