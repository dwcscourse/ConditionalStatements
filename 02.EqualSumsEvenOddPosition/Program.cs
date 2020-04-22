using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();
                int sumEven = 0;
                int sumOdd = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        sumEven += Convert.ToInt32(currentNum[j]);
                    }
                    else
                    {
                        sumOdd += Convert.ToInt32(currentNum[j]);
                    }
                }

                if (sumEven == sumOdd)
                {
                    Console.Write(currentNum + " ");
                }

            }

        }
    }
}
