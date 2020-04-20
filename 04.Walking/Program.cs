using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 10000;
            int steps = 0;
            int stepsPerDay = 0;
            bool isGoingHome = false;

            while (stepsPerDay < goal) 
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    isGoingHome = true;
                }

                steps = int.Parse(input);
                stepsPerDay += steps;

                if (isGoingHome)
                {
                    break;
                }
            }

            if (stepsPerDay >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else if (isGoingHome)
            {
                Console.WriteLine($"{goal - stepsPerDay} more steps to reach goal.");
            }
        }
    }
}
