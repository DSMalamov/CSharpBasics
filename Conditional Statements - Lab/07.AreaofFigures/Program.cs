using System;

namespace _07.AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //· Ако фигурата е квадрат(square): на следващия ред се чете едно дробно число -дължина на страната му

                //· Ако фигурата е правоъгълник(rectangle): на следващите два реда четат две дробни числа -дължините на страните му

                //· Ако фигурата е кръг(circle): на следващия ред чете едно дробно число - радиусът на кръга

                //· Ако фигурата е триъгълник(triangle): на следващите два реда четат две дробни числа -дължината на страната му и дължината на височината към нея

            string input = Console.ReadLine();
            if (input == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double result = Math.Round(sideA * sideA, 3);
                Console.WriteLine(result);
            }
            else if (input == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double result = Math.Round(sideB * sideA, 3);
                Console.WriteLine(result);
            }
            else if (input == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double result = Math.Round(radius * radius * Math.PI, 3);
                Console.WriteLine(result);
            }
            else if (input == "triangle") 
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double result = Math.Round(sideA * sideB / 2, 3);
                Console.WriteLine(result);
            }
        }
    }
}
