using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzlesCount = int.Parse(Console.ReadLine());
            int dolsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            int totalToysCount = puzzlesCount + dolsCount + bearsCount + minionsCount + truckCount;

            double puzzlesPrice = puzzlesCount * 2.60;
            double dolsPrice = dolsCount * 3;
            double bearsPrice = bearsCount * 4.10;
            double minionsPrice = minionsCount * 8.20;
            double truckPrice = truckCount * 2;

            double totalToysPrice = puzzlesPrice + dolsPrice + bearsPrice + minionsPrice + truckPrice;

            if (totalToysCount >= 50)
            {
                totalToysPrice = totalToysPrice - (totalToysPrice * 0.25);
            }

            double profit = totalToysPrice - (totalToysPrice * 0.10);

            if (profit >= tripPrice)
            {
                Console.WriteLine($"Yes! {profit - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - profit:f2} lv needed.");
            }
        }
    }
}
