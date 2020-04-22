using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJudges = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            double totalAssessment = 0;
            int presentationsCounter = 0;

            while (presentation != "Finish")
            {
                
                double scoreTotal = 0;
                presentationsCounter++;

                for (int i = 1; i <= numberOfJudges; i++)
                {
                    double score = double.Parse(Console.ReadLine());
                    scoreTotal += score;
                }

                double meanScore = scoreTotal / numberOfJudges;
                totalAssessment += meanScore;
                Console.WriteLine($"{presentation} - {meanScore:f2}.");
                
                presentation = Console.ReadLine();

            }

            double finalAssessment = totalAssessment / presentationsCounter;
            Console.WriteLine($"Student's final assessment is {finalAssessment:f2}.");

        }
    }
}
