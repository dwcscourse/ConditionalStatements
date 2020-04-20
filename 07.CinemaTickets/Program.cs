using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            int totalTickes = 0;
            int totalStudentTickets = 0;
            int totalStandardTickets = 0;
            int totalKidsTickets = 0;

            while (film != "Finish")
            {
                int totalSeats = int.Parse(Console.ReadLine());
                int currentTickets = 0;

                while (currentTickets < totalSeats)
                {
                    string typeOfTicket = Console.ReadLine();
                    if (typeOfTicket == "End")
                    {
                        break;
                    }
                    currentTickets++;

                    switch (typeOfTicket)
                    {
                        case "standard":
                            totalStandardTickets++;
                            break;
                        case "kid":
                            totalKidsTickets++;
                            break;
                        case "student":
                            totalStudentTickets++;
                            break;
                    }
                }

                totalTickes += currentTickets;

                double smetki = currentTickets * 1.0 / totalSeats * 100;
                Console.WriteLine($"{film} - {smetki:f2}% full.");
                film = Console.ReadLine();
            }

            double studentTicketsPercent = totalStudentTickets * 1.0 / totalTickes * 100;
            double standardTicketsPercent = totalStandardTickets * 1.0 / totalTickes * 100;
            double kidsTicketsPercent = totalKidsTickets * 1.0 / totalTickes * 100;
            Console.WriteLine($"Total tickets: {totalTickes}");
            Console.WriteLine($"{studentTicketsPercent:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPercent:f2}% standard tickets.");
            Console.WriteLine($"{kidsTicketsPercent:f2}% kids tickets.");

        }
    }
}
