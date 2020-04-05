using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums  = int.Parse(Console.ReadLine());

            double income = 0.0;

            switch (type)
            {
                case "Premiere":
                    income = rows * colums * 12;
                    break;
                case "Normal":
                    income = rows * colums * 7.5;
                    break;
                case "Discount":
                    income = rows * colums * 5;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{income:f2} leva");
        }
    }
}
