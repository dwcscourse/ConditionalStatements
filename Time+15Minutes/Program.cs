using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hour * 60 + minutes + 15;

            int newHour = totalMinutes / 60;
            int newMinutes = totalMinutes % 60;

            if (newHour >= 24)
            {
                newHour = newHour % 24;
            }

            if (newMinutes >= 60)
            {
                newMinutes = newMinutes % 60;
            }

            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHour}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHour}:{newMinutes}");
            }
        }
    }
}
