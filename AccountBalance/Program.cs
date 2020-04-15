using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDebit = int.Parse(Console.ReadLine());
            double sum = 0;

            while(numberOfDebit!=0)
            {
                double debit = double.Parse(Console.ReadLine());
                numberOfDebit -= 1;

                if (debit <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += debit;
                Console.WriteLine($"Increase: {debit:f2}");

            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
