using System;

namespace _04.CinemaVoucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s = "Captain Marvel";
            //char m = s[1];
            //Console.WriteLine(m);
            //string mn = m.ToString();
            //Console.WriteLine(mn);
            int products = 0;
            int ticket = 0;
            int vaucher = int.Parse(Console.ReadLine());
            int price = 0;
         
            while (true)
            {
                string input = Console.ReadLine();
                int sl = input.Length;

                if (input == "End")
                {
                    break;
                }

                if (sl > 8)
                {
                    char sl1 = input[0];
                    char sl2 = input[1];
                    string sl3 = sl1.ToString();
                    string sl4 = sl2.ToString();
                    foreach (var c in sl3)
                    {
                        price += ((int)c);
                    }
                    foreach (var c in sl4)
                    {
                        price += ((int)c);

                    }

                    if (vaucher >= price)
                    {
                        vaucher -= price;
                        ticket++;
                    }
                    else
                    {
                        break;
                    }
                    


                }

                else if (sl <= 8)
                {
                    char sl1 = input[0];
                    string sl3 = sl1.ToString();
                    foreach (var c in sl3)
                    {
                        price += ((int)c);
                    }
                    
                    if (vaucher >= price)
                    {
                        vaucher -= price;
                        products++;
                    }
                    else
                    {
                        break;
                    }
                }
                

                price = 0;
            }
                Console.WriteLine(ticket);
                Console.WriteLine(products);
            

        }
    }
}
