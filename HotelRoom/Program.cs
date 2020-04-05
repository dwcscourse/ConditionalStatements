using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());
            double priceOfStudio = 0;
            double priceOfAppartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    priceOfStudio = 50;
                    priceOfAppartment = 65;
                    break;

                case "June":
                case "September":
                    priceOfStudio = 75.2;
                    priceOfAppartment = 68.7;
                    break;

                case "July":
                case "August":
                    priceOfStudio = 76;
                    priceOfAppartment = 77;
                    break;

                default:
                    break;
            }

            if (numberOfNights > 14)
            {
                priceOfAppartment *= 0.9;
                if (month == "June" || month == "September")
                {
                    priceOfStudio *= 0.8;
                }
                else if (month == "May" || month == "October")
                {
                    priceOfStudio *= 0.7;
                }
            }
            else if ((numberOfNights > 7 && numberOfNights <= 14) && (month == "May" || month == "October"))
            {
                priceOfStudio *= 0.95;
            }

            double totalPriceApartment = priceOfAppartment * numberOfNights;
            double totalPriceStudio = priceOfStudio * numberOfNights;

            Console.WriteLine($"Apartment: {totalPriceApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:f2} lv.");
        }
    }
}
