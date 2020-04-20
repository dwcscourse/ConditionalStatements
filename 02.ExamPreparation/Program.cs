using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoorGrades = int.Parse(Console.ReadLine());
            double grade = 0;
            int countPoorGrades = 0;
            int numberOfTasks = 0;
            bool isTasksAreEnough = false;
            double averageScore = 0;
            double sumOfGrades = 0;
            string lastTask = "";

            while (numberOfPoorGrades > countPoorGrades )
            {
                string taskName = Console.ReadLine();

                if (taskName == "Enough")
                {
                    isTasksAreEnough = true;
                    break;
                }

                lastTask = taskName;
                numberOfTasks++;
                grade = double.Parse(Console.ReadLine());
                sumOfGrades += grade;
                averageScore = sumOfGrades / numberOfTasks;

                if (grade <= 4)
                {
                    countPoorGrades++;
                }
            }

            if (isTasksAreEnough)
            {
                Console.WriteLine($"Average score: {averageScore:f2}");
                Console.WriteLine($"Number of problems: {numberOfTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
            else
            {
                Console.WriteLine($"You need a break, {countPoorGrades} poor grades.");
            }
        }
    }
}
