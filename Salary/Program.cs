using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOftabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOftabs; i++)
            {
                if(salary != 0)
                {
                    string tab = Console.ReadLine();
                    switch (tab)
                    {
                        case "Facebook":
                            salary = salary - 150;
                            break;
                        case "Instagram":
                            salary = salary - 100;
                            break;
                        case "Reddit":
                            salary = salary - 50;
                            break;
                        default:
                            break;
                    }
                }               
            }

            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
