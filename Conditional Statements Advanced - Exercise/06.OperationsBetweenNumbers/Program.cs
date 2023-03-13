using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            char deistvie = char.Parse(Console.ReadLine());
            double result = 0;
           


            if (deistvie == '+')
            {
                result = n1 + n2;
                double chetnost = result % 2;


                Console.Write($"{n1} + {n2} = {result}");

                if (chetnost == 0)
                {
                    Console.WriteLine($" - even");
                }
                else
                {
                    Console.WriteLine($" - odd");
                }
            }
            else if (deistvie == '-')
            {
                result = n1 - n2;
                double chetnost = result % 2;

                Console.Write($"{n1} - {n2} = {result}");

                
                if (chetnost == 0)
                {
                    Console.WriteLine($" - even");
                }
                else
                {
                    Console.WriteLine($" - odd");
                }
            }
            else if (deistvie == '*')
            {
                result = n1 * n2;
                Console.Write($"{n1} * {n2} = {result}");

                double chetnost = result % 2;

                if (chetnost == 0)
                {
                    Console.WriteLine($" - even");
                }
                else
                {
                    Console.WriteLine($" - odd");
                }
            }

            if (deistvie == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {result:f2}");
                }
      
                
            }
            else if (deistvie == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    result = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
               
            }
               
           
        }
    }
}
