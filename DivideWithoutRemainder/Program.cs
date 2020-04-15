using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double module2 = 0;
            double module3 = 0;
            double module4 = 0;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    module2++;
                }
                if (num % 3 == 0)
                {
                    module3++;
                }
                if (num % 4 == 0)
                {
                    module4++;
                }
            }

            Console.WriteLine($"{module2 / n *100:f2}%");
            Console.WriteLine($"{module3 / n *100:f2}%");
            Console.WriteLine($"{module4 / n * 100:f2}%");


        }
    }
}
