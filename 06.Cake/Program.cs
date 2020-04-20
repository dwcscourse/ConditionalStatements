using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakePieces = width * length;

            string input = "";

            while (cakePieces > 0)
            {
                input = Console.ReadLine();

                if (input == "STOP")
                {
                    break;
                }
                else
                {
                    int pieces = int.Parse(input);
                    cakePieces -= pieces;

                }
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }
        }
    }
}
