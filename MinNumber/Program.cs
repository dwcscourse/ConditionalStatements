using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            while (n - 1 > 0)
            {
                int num = int.Parse(Console.ReadLine());
                n--;

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}
