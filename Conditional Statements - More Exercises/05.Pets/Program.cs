using System;

namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – брой дни – цяло число в интервал [1…5000]
            //•	Втори ред – оставена храна в килограми – цяло число в интервал [0…100000]
            //•	Трети ред – храна на ден за кучето в килограми – реално число в интервал [0.00…100.00]
            //•	Четвърти ред – храна на ден за котката в килограми– реално число в интервал [0.00…100.00]
            //•	Пети ред – храна на ден за костенурката в грамове – реално число в интервал [0.00…10000.00]

            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            double totalTurtleFood = turtleFood / 1000;
            double totalFood = days * (dogFood + catFood + totalTurtleFood);
            
            if (food >= totalFood) 
            {
                double rest = Math.Floor(food - totalFood);
                Console.WriteLine($"{rest} kilos of food left.");
            
            }
            else 
            {
                double fneeded = Math.Ceiling(totalFood - food);
                Console.WriteLine($"{fneeded} more kilos of food are needed.");
            
            }


        }
    }
}
