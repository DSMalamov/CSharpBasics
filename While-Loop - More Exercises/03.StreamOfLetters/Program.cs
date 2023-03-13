using System;

namespace _03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            int o = 0;
            int n = 0;
            string word = string.Empty;
            string fullWord = string.Empty;


            while (true)
            {
                bool check = false;

                string letter = Console.ReadLine();

                for (int i = 0; i < letter.Length ; i++)
                {
                    if (letter[i] >= 'a' && letter[i] <= 'z' || letter[i] >= 'A' && letter[i] <= 'Z')
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check == false) 
                {
                    
                    continue;
                
                }  
               

                if (letter == "End") 
                {
                    Console.WriteLine(fullWord);
                    break;
                }

                if (letter == "c")
                {
                    c++;
                    if (c>1)
                    {
                        word += letter;
                    }
                }
                else if (letter == "o")
                {
                    o++;
                    if (o > 1)
                    {
                        word += letter;
                    }
                }
                else if (letter == "n")
                {
                    n++;
                    if (n > 1)
                    {
                        word += letter;
                    }
                }
                else
                {
                    word += letter;
                }
                if (c >= 1 && o >= 1 & n >=1)
                {
                    word += " ";
                    c=0;
                    n=0;
                    o=0;
                    fullWord+= word;
                    word = string.Empty;
                }
            }
        }
    }
}
