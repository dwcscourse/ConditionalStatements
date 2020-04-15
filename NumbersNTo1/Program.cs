using System;

namespace NumbersNTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = input; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
