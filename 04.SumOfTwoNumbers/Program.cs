using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magictNum = int.Parse(Console.ReadLine());
            int combinationCount = 0;
            bool isThereMagicComb = false;


            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    combinationCount++;
                    if (i + j == magictNum)
                    {
                        isThereMagicComb = true;
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {j} = {magictNum})");
                    }
                }
                if (isThereMagicComb)
                {
                    break;
                }
            }

            if (!isThereMagicComb)
            {
                Console.WriteLine($"{combinationCount} combinations - neither equals {magictNum}");
            }
        }
    }
}
