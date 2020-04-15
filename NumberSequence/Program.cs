using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temp = int.Parse(Console.ReadLine());

            int min = temp;
            int max = temp;

            for (int i = 1; i < number; i++)
            {
                temp = int.Parse(Console.ReadLine());

                if (min > temp)
                {
                    min = temp;
                }

                if (max < temp)
                {
                    max = temp;
                }
            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
