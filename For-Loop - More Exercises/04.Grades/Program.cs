using System;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            double mark = 0;
            int ex = 0;
            int gr = 0;
            int go = 0;
            int f = 0;
            double total = 0;


            for (int i = 0; i < numberOfStudents; i++)
            {
                mark = double.Parse(Console.ReadLine());
                total += mark;

                if (mark >= 5.00)
                {
                    ex++;
                }
                else if (mark >= 4.00)
                {
                    gr++;
                }
                else if(mark >= 3.00) 
                { 
                    go++;
                }
                else 
                {
                    f++;
                }

            }
            Console.WriteLine($"Top students: {100 * 1.0 / numberOfStudents * ex:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {100 * 1.0 / numberOfStudents * gr:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {100 * 1.0 / numberOfStudents * go:f2}%");
            Console.WriteLine($"Fail: {100 * 1.0 / numberOfStudents * f:f2}%");
            Console.WriteLine($"Average: {total/numberOfStudents:f2}");
        }
    }
}
