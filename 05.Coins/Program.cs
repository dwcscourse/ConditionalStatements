using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int cents = (int)(change * 100);
            int countCoins = 0;

            //while (Math.Round(change, 2) > 0)
            //{
            //    if (change >= 2)
            //    {
            //        countCoins += Convert.ToInt32(Math.Floor(change / 2));
            //        change = change % 2;
            //        change = Math.Round(change, 2);

            //    }
            //    else if (change >= 1)
            //    {
            //        countCoins += Convert.ToInt32(Math.Floor(change / 1));
            //        change = change % 1;
            //        change = Math.Round(change, 2);
            //    }

            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    countCoins++;
                    cents -= 200;
                }
                else if (cents - 100 >= 0)
                {
                    countCoins++;
                    cents -= 100;
                }
                else if (cents - 50 >= 0)
                {
                    countCoins++;
                    cents -= 50;
                }
                else if (cents - 20 >= 0)
                {
                    countCoins++;
                    cents -= 20;
                }
                else if (cents - 10 >= 0)
                {
                    countCoins++;
                    cents -= 10;
                }
                else if (cents - 5 >= 0)
                {
                    countCoins++;
                    cents -= 5;
                }
                else if (cents - 2 >= 0)
                {
                    countCoins++;
                    cents -= 2;
                }
                else if (cents - 1 >= 0)
                {
                    countCoins++;
                    cents -= 1;
                }
            }

            Console.WriteLine(countCoins);
        }
    }
}
