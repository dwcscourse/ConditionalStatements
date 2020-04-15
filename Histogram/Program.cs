using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double numbersTo199 = 0;
            double numbersTo399 = 0;
            double numbersTo599 = 0;
            double numbersTo799 = 0;
            double numbersAbove800 = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    numbersTo199++;
                }
                else if (number >= 200 && number < 400)
                {
                    numbersTo399++;
                }
                else if (number >= 400 && number < 600)
                {
                    numbersTo599++;
                }
                else if (number >= 600 && number < 800)
                {
                    numbersTo799++;
                }
                else
                {
                    numbersAbove800++;
                }
            }

            Console.WriteLine($"{ numbersTo199 / n * 100:f2}%");
            Console.WriteLine($"{ numbersTo399 / n * 100:f2}%");
            Console.WriteLine($"{ numbersTo599 / n * 100:f2}%");
            Console.WriteLine($"{ numbersTo799 / n * 100:f2}%");
            Console.WriteLine($"{ numbersAbove800 / n * 100:f2}%");

        }
    }
}
