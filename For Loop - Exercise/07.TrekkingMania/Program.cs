using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int members = 0;
            int musala = 0;
            int monblan = 0;
            int kilimanjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                members = int.Parse(Console.ReadLine());

                if (members <= 5)
                {
                    musala += members;
                }
                else if (members >5 && members <= 12)
                {
                    monblan += members;
                }
                else if (members > 12 && members <= 25)
                {
                    kilimanjaro += members;
                }
                else if (members > 25 && members <= 40)
                {
                    k2 += members;
                }
                else if (members > 40)
                {
                    everest += members;
                }
            }
            int totalMembers = musala + monblan + kilimanjaro + everest + k2;
            Console.WriteLine($"{musala * 1.0 / totalMembers * 100:f2}%");
            Console.WriteLine($"{monblan * 1.0 / totalMembers * 100:f2}%");
            Console.WriteLine($"{kilimanjaro * 1.0 / totalMembers * 100:f2}%");
            Console.WriteLine($"{k2 * 1.0 / totalMembers * 100:f2}%");
            Console.WriteLine($"{everest * 1.0 / totalMembers * 100:f2}%");


        }
    }
}
