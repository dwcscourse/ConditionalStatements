using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            string operator1 = Console.ReadLine();
            double result = 0;

            if (operator1 == "+")
            {
                result = number1 + number2;
            }
            else if (operator1 == "-")
            {
                result = number1 - number2;
            }
            else if (operator1 == "*")
            {
                result = number1 * number2;
            }
            else if (operator1 == "/" && number2 != 0)
            {
                result = number1 / number2;
                Console.WriteLine($"{number1} {operator1} {number2} = {result:f2}");
            }
            else if (operator1 == "%" && number2 != 0)
            {
                result = number1 % number2;
                Console.WriteLine($"{number1} {operator1} {number2} = {result}");
            }
            else if ((operator1 == "/" || operator1 == "%" ) && number2 == 0)
            {
                Console.WriteLine($"Cannot divide {number1} by zero");
            }

            if (operator1 == "+" || operator1 == "-" || operator1 == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {operator1} {number2} = {result} - odd");
                }
            }
        }
    }
}
