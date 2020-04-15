using System;

namespace SumNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0;

            while (input != "Stop")
            {
                int num = int.Parse(input);
                sum += num;
                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
