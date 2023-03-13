using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fBook = Console.ReadLine();
            int booksChecked = 0;
            string currentBook = Console.ReadLine();

            while (currentBook != fBook)
            {
                booksChecked ++;
                if (currentBook == "No More Books")
                {
                    booksChecked --;
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {booksChecked} books.");
                    break;
                }
                currentBook = Console.ReadLine();
            }
            if (fBook == currentBook)
            {
                Console.WriteLine($"You checked {booksChecked} books and found it.");
            }
        }
    }
}
