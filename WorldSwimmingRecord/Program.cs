using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double distanceInSeconds = distanceInMeters * timeInSeconds;

            double addSeconds = Math.Floor(distanceInMeters / 15) * 12.5;

            double totalSeconds = distanceInSeconds + addSeconds;

            if (totalSeconds >= recordInSec)
            {
                Console.WriteLine($"No, he failed! He was {totalSeconds - recordInSec:f2} seconds slower.");
            }
            else 
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSeconds:f2} seconds.");
            }
        }
    }
}
