using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string entranceMetric = Console.ReadLine();
            string exitMetric = Console.ReadLine();
            double converted = 0.0;

            if (entranceMetric == "m" && exitMetric == "mm")
            {
                converted = number * 1000; 
            }
            if (entranceMetric == "m" && exitMetric == "cm")
            {
                converted = number * 100;
            }
            if (entranceMetric == "mm" && exitMetric == "m")
            {
                converted = number / 1000;
            }
            if (entranceMetric == "cm" && exitMetric == "m")
            {
                converted = number / 100;
            }
            if (entranceMetric == "mm" && exitMetric == "cm")
            {
                converted = number * 0.1;
            }
            if (entranceMetric == "cm" && exitMetric == "mm")
            {
                converted = number * 10;
            }

            Console.WriteLine($"{converted:f3}");
        }
    }
}
