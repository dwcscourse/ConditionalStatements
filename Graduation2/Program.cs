using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grade = 1;
            double mark = 0;
            double averageScore = 0;
            double sumOfMarks = 0;
            int skysan = 0;

            while (grade <= 12 && skysan < 2)
            {
                mark = double.Parse(Console.ReadLine());

                if (mark >= 4)
                {
                    sumOfMarks += mark;
                    averageScore = sumOfMarks / grade;
                    grade++;
                }
                else
                {
                    skysan++;
                }
            }

            if (skysan >= 2)
            {
                Console.WriteLine($"{name} has been excluded at {grade} grade");
            }
            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageScore:f2}");
            }
        }
    }
}
