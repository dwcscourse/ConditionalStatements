using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = -1000000000.0;
            double oddMax = 1000000000.0;

            double evenSum = 0;
            double evenMin = -1000000000.0;
            double evenMax = 1000000000.0;

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num > evenMax || evenMax == 1000000000.0)
                    {
                        evenMax = num;
                    }

                    if (num < evenMin || evenMin == -1000000000.0)
                    {
                        evenMin = num;
                    }

                }
                else
                {
                    oddSum += num;
                    if (num > oddMax || oddMax == 1000000000.0)
                    {
                        oddMax = num;
                    }

                    if (num < oddMin || oddMin == -1000000000.0)
                    {
                        oddMin = num;
                    }
                }

            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == -1000000000.0)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }

            if (oddMax == 1000000000.0)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }

            //----------------

            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == -1000000000.0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }

            if (evenMax == 1000000000.0)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
