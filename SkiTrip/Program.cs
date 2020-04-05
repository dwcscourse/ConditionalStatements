using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double price = 0;
            days = days - 1;

            if (typeOfRoom == "room for one person")
            {
                price = 18;
            }
            else if (typeOfRoom == "apartment")
            {
                price = 25;
            }
            else
            {
                price = 35;
            }

            switch (typeOfRoom)
            {
                case "apartment":
                    if (days < 10)
                    {
                        price = price * 0.7;                           
                    }
                    else if (days >= 10 && days <=15)
                    {
                        price = price * 0.65;
                    }
                    else if (days > 15)
                    {
                        price = price * 0.5;
                    }
                    break;
                case "president apartment":
                    if (days < 10)
                    {
                        price = price * 0.9;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = price * 0.85;
                    }
                    else if (days > 15)
                    {
                        price = price * 0.8;
                    }
                    break;
                default:
                    break;
            }

            double totalPrice = price * days;

            if (evaluation == "positive")
            {
                totalPrice *= 1.25;
            }
            else
                totalPrice *= 0.9;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
