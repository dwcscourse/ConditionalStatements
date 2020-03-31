using System;

namespace GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double priceOfStatistClote = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;
            double clotesPrice = statisti * priceOfStatistClote;

            if (statisti > 150 )
            {
                clotesPrice = clotesPrice - clotesPrice * 0.1;
            }

            double costs = decorPrice + clotesPrice;

            if ( costs > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {costs - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - costs:f2} leva left.");
            }
        }
    }
}
