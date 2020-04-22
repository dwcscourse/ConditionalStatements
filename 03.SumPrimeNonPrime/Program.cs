using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumOfPrime = 0;
            int sumOfNotPrime = 0;
            bool isPrime = true;



            while (input != "stop")
            {
                int number = int.Parse(input);
                bool isNegative = false;

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    isNegative = true;
                }

                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }

                }


                //not prime
                if (!isPrime && !isNegative || number == 1)
                {
                    sumOfNotPrime += number;
                }
                else if (isPrime && !isNegative)
                {
                    sumOfPrime += number;
                }

                input = Console.ReadLine();

            }
            Console.WriteLine("Sum of all prime numbers is: " + sumOfPrime);
            Console.WriteLine("Sum of all non prime numbers is: " + sumOfNotPrime);
        }
    }
}
