using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double mark = double.Parse(Console.ReadLine());
            int grade = 1;
            int fails = 0;
            double sum = 0;
            double avaragemarks = 0;

            while (grade <= 12)
            {
                if (mark <4.00)
                {
                    fails++;
                    
                }
                if (fails >= 2)
                {
                    grade--;
                    Console.WriteLine($"{name} has been excluded at {grade} grade");
                    break;
                }
                sum += mark;
              
                avaragemarks = sum/grade;
                grade++;

                if (grade > 12) 
                {
                    Console.WriteLine($"{name} graduated. Average grade: {avaragemarks:f2}");
                    break;
                }

                mark = double.Parse(Console.ReadLine());

            }
            
        }
    }
}
