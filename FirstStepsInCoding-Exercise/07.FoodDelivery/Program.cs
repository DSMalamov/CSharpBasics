using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cMeals = int.Parse(Console.ReadLine());
            int fMeals = int.Parse(Console.ReadLine());
            int vMeals = int.Parse(Console.ReadLine());
            double ppcMeal = 10.35 * cMeals;
            double ppfMelas = 12.40 * fMeals;
            double ppvMeals = 8.15 * vMeals;
            double dessert = (ppcMeal + ppfMelas + ppvMeals) * 0.20;
            double finalp = ppcMeal + ppfMelas + ppvMeals + dessert + 2.50;
            Console.WriteLine(finalp);

        }
    }
}
