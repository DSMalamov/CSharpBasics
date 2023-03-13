using System;

namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hE = int.Parse(Console.ReadLine());
            int mE = int.Parse(Console.ReadLine());
            int hA = int.Parse(Console.ReadLine());
            int mA = int.Parse(Console.ReadLine());

            int examInMin = (hE * 60) + mE;
            int arrivalInMin = (hA * 60) + mA;
            int razlika = examInMin - arrivalInMin;

            if (razlika < 0)
            {
                Console.WriteLine("Late");
                if (razlika > -60)
                {
                    razlika *= -1;
                    Console.WriteLine($"{razlika} minutes after the start");
                }
                else
                {
                    razlika *= -1;
                    int hoursraz = razlika / 60;
                    int minsraz = razlika % 60;
                    Console.WriteLine($"{hoursraz}:{minsraz:d2} hours after the start");
                }
            }
            else if (razlika >= 0 && razlika <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{razlika} minutes before the start");

            }
            else if (razlika > 30)
            {
                Console.WriteLine("Early");
                if (razlika <= 59)
                {
                    
                    Console.WriteLine($"{razlika} minutes before the start");
                }
                else
                {
                   
                    int hoursraz = razlika / 60;
                    int minsraz = razlika % 60;
                    Console.WriteLine($"{hoursraz}:{minsraz:d2} hours before the start");
                }
            }

        }
    }
}
