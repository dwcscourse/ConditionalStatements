using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWаshMach = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                   sum += (i/2 * 10) - 1;
                }
                else
                {
                    sum += priceToy;
                }
            }

            if (sum >= priceWаshMach )
            {
                Console.WriteLine($"Yes! {sum - priceWаshMach:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWаshMach - sum:f2}");    
            }
        }
    }
}
