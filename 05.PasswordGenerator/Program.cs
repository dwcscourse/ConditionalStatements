using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Символ 1: цифра от 1 до n.
            //Символ 2: цифра от 1 до n.
            //Символ 3: малка буква измежду първите l букви на латинската азбука.
            //Символ 4: малка буква измежду първите l букви на латинската азбука.
            //Символ 5: цифра от 1 до n, по-голяма от първите 2 цифри.

            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (int third = 'a'; third < 'a' + l; third++)
                    {
                        for (int fourth = 'a'; fourth < 'a' + l; fourth++)
                        {
                            int maxNum = Math.Max(first, second);
                            for (int fifth = maxNum +1; fifth <= n; fifth++)
                            {
                                Console.Write($"{first}{second}{(char) third}{(char)fourth}{fifth} ");
                            }

                        }

                    }

                }
            }

        }
    }
}
