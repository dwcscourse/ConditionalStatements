using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            
            while (destination != "End")
            {
                double minBudget = double.Parse(Console.ReadLine());

                double budget = 0;

                while (budget < minBudget)
                {
                    double money = double.Parse(Console.ReadLine());
                    budget += money;
                }
                Console.WriteLine($"Going to {destination}!");
                
                destination = Console.ReadLine();
            }
        }
    }
}
