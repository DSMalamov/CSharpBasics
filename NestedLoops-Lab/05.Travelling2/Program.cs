using System;

namespace _05.Travelling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int currentfloor = floors; currentfloor >= 1; currentfloor--)
            {
                for (int currentRoom = 0; currentRoom < rooms; currentRoom++)
                {
                    if (currentfloor == floors)
                    {
                        Console.Write($"L{currentfloor}{currentRoom} ");
                    }
                    else if (currentfloor % 2 == 0) 
                    {
                        Console.Write($"O{currentfloor}{currentRoom} ");
                    }
                    else
                    {
                        Console.Write($"A{currentfloor}{currentRoom} ");
                    }
                    
                }
                Console.WriteLine();
            }
             
        }
    }
}
