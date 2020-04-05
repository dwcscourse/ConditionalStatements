using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishman = int.Parse(Console.ReadLine());

            double costs = 0;

            switch (season)
            {
                case "Spring":
                    if (numberOfFishman <= 6 )
                    {
                        costs = 3000 - 3000 * 0.1; 
                    }
                    else if (numberOfFishman >= 7 && numberOfFishman <=11)
                    {
                        costs = 3000 - 3000 * 0.15;
                    }
                    else
                    {
                        costs = 3000 - 3000 * 0.25;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    if (numberOfFishman <= 6)
                    {
                        costs = 4200 - 4200 * 0.1;
                    }
                    else if (numberOfFishman >= 7 && numberOfFishman <= 11)
                    {
                        costs = 4200 - (4200 * 0.15);
                    }
                    else
                    {
                        costs = 4200 - 4200 * 0.25;
                    }
                    break;
                case "Winter":
                    if (numberOfFishman <= 6)
                    {
                        costs = 2600 - 2600 * 0.1;
                    }
                    else if (numberOfFishman >= 7 && numberOfFishman <= 11)
                    {
                        costs = 2600 - 2600 * 0.15;
                    }
                    else
                    {
                        costs = 2600 - 2600 * 0.25;
                    }
                    break;

                default:
                    break;
            }

            if (numberOfFishman % 2 == 0 && season != "Autumn")
            {
                costs = costs - costs * 0.05;
            }

            if (budget >= costs)
            {
                Console.WriteLine($"Yes! You have {budget - costs:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {costs - budget:f2} leva.");
            }
        }
    }
}
