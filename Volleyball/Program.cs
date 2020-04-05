using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfWeekendToHometown = int.Parse(Console.ReadLine());

            double playVolleyball = 0;

            int weekednInSofia = 48 - numberOfWeekendToHometown;

            playVolleyball = (weekednInSofia * 3.0 / 4) + (numberOfHolidays * 2.0 /3) + numberOfWeekendToHometown;


            if (typeOfYear == "leap")
            {
                playVolleyball *= 1.15;
            }

            Console.WriteLine($"{Math.Floor(playVolleyball)}");
        }
    }
}
