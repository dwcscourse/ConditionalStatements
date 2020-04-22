using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool IsSpecial = true;

                int candidateForSpecialNum = i;
                for (int j = 1; j <= 4; j++)
                {
                    int digit = candidateForSpecialNum % 10;
                    candidateForSpecialNum /= 10;

                    if (digit == 0 || number % digit != 0)
                    {
                        IsSpecial = false;
                        break;
                    }
                }

                if (IsSpecial)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
