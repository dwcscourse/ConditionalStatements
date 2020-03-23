using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //(square, rectangle, circle или triangle).
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                double num = double.Parse(Console.ReadLine());
                area = num * num;
            }
            else if (figure =="rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double heightA = double.Parse(Console.ReadLine());
                area = sideA * heightA / 2;        
            }

            Console.WriteLine($"{area:f3}");
        }
    }
}
