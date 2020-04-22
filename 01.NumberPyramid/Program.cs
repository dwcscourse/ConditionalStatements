using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            int i = 1;

            while (i <= number)
            {
                for (int j = 1; j <= counter; j++)
                {
                    Console.Write($"{i} ");
                    i++;
                    if (i == number + 1)
                    {
                        break;
                    }
                }
                counter++;
                Console.WriteLine();
            }      
        }
    }
}
