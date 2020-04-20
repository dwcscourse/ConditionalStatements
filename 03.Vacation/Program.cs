using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double balance = double.Parse(Console.ReadLine());
            string action = "";
            double amount = 0;
            int countSpend = 0;
            int days = 0;



            while (balance < tripPrice && countSpend < 5)
            {
                action = Console.ReadLine();
                amount = double.Parse(Console.ReadLine());
                days++;

                if (action == "spend")
                {
                    if (balance < amount)
                    {
                        balance = 0;
                    }
                    else
                    {
                        balance -= amount;
                    }
                    countSpend++;
                }
                else if (action == "save")
                {
                    balance += amount;
                    countSpend = 0;
                }
            }

            if (countSpend == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
