using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            bool isValid = true;
            double fee = 0;

            switch (town)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        fee = sales * 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        fee = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        fee = sales * 0.08;
                    }
                    else if (sales > 10000)
                    {
                        fee = sales * 0.12;
                    }
                    else
                    {
                        isValid = false;
                    }
                    break;
                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        fee = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        fee = sales * 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        fee = sales * 0.10;
                    }
                    else if (sales > 10000)
                    {
                        fee = sales * 0.13;
                    }
                    else
                    {
                        isValid = false;
                    }
                    break;
                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        fee = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        fee = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        fee = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        fee = sales * 0.145;
                    }
                    else
                    {
                        isValid = false;
                    }
                    break;
                default:
                    isValid = false;
                    break;
            }

            if (isValid)
            {
                Console.WriteLine($"{fee:f2}");
            }
            else
                Console.WriteLine("error");
        }
    }
}
