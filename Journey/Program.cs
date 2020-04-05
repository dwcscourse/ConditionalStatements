using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = "Hotel";
            string destination = "";
            double cost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "Europe";
                cost = budget * 0.9;
            }


            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        place = "Camp";
                        cost = budget * 0.3;
                    }
                    else if (budget <= 1000)
                    {
                        place = "Camp";
                        cost = budget * 0.4;
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        cost = budget * 0.7;
                    }
                    else if (budget <= 1000)
                    {
                        cost = budget * 0.8;
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {cost:f2}");
        }
    }
}
