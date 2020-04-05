using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minutesOfArrival = int.Parse(Console.ReadLine());

            int timeOfExam = hourOfExam * 60 + minutesOfExam;
            int timeOfArrival = hourOfArrival * 60 + minutesOfArrival;

            int hour = 0;
            int minutes = 0;

            if (timeOfArrival > timeOfExam)
            {
                Console.WriteLine("Late");
            }
            else if (timeOfExam - timeOfArrival <= 30)
            {
                Console.WriteLine("On time");
            }
            else if (timeOfExam - timeOfArrival > 30)
            {
                Console.WriteLine("Early");

            }

            if (timeOfExam - timeOfArrival > 0 && timeOfExam - timeOfArrival < 60)
            {
                Console.WriteLine($"{timeOfExam - timeOfArrival} minutes before the start");
            }
            else if (timeOfExam - timeOfArrival >= 60)
            {
                hour = (timeOfExam - timeOfArrival) / 60;
                minutes = (timeOfExam - timeOfArrival) % 60;

                if (minutes < 10)
                {
                    Console.WriteLine($"{hour}:0{minutes} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutes} hours before the start");
                }
            }
            else if (timeOfArrival - timeOfExam > 0 && timeOfArrival - timeOfExam < 60)
            {
                Console.WriteLine($"{timeOfArrival - timeOfExam} minutes after the start");
            }
            else if (timeOfArrival - timeOfExam >= 60)
            {
                hour = (timeOfArrival - timeOfExam) / 60;
                minutes = (timeOfArrival - timeOfExam) % 60;

                if (minutes < 10)
                {
                    Console.WriteLine($"{hour}:0{minutes} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutes} hours after the start");
                }
            }
        }
    }
}
