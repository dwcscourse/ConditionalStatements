using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            while (n - 1 > 0)
            {
                int num = int.Parse(Console.ReadLine());
                n--;

                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
