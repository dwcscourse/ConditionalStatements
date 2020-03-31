using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double evaluation = double.Parse(Console.ReadLine());
            double minimalSalary = double.Parse(Console.ReadLine());

            double socialScholarship = minimalSalary * 0.35;
            double excellenceScholarship = evaluation * 25;
            
            if (evaluation >= 5.5)
            {
                if (income < minimalSalary && socialScholarship > excellenceScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellenceScholarship)} BGN");
                }
            }
            else if (evaluation > 4.5 && income < minimalSalary)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else 
            {
                Console.WriteLine("You cannot get a scholarship!");
            }       
        }
    }
}
