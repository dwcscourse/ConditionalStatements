using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double  cost = 0;

            switch (typeOfFlower)
            {
                case "Roses":
                    cost = 5;
                    if (numberOfFlowers > 80)
                    {
                        cost *= 0.9;
                    }
                    break;
                case "Dahlias":
                    cost = 3.8;
                    if (numberOfFlowers > 90)
                    {
                        cost *= 0.85;
                    }
                    break;
                case "Tulips":
                    cost = 2.8;
                    if (numberOfFlowers > 80)
                    {
                        cost *=  0.85;
                    }
                    break;
                case "Narcissus":
                    cost = 3;
                    if (numberOfFlowers < 120)
                    {
                        cost *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    cost = 2.5;
                    if (numberOfFlowers < 80)
                    {
                        cost *= 1.2;
                    }
                    break;
                default:
                    break;
            }

            //total
            cost *= numberOfFlowers;


            if (budget >= cost)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {cost - budget:f2} leva more.");

            }


        }
    }
}
