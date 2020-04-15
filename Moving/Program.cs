using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string input = "";
            bool noMoreSpace = false;
            int freeSpace = width * length * height;

            while (noMoreSpace != true)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }

                int numberOfBoxes = int.Parse(input);
                freeSpace -= numberOfBoxes;

                if (freeSpace < 0)
                {
                    noMoreSpace = true;
                }
            }

            if (noMoreSpace == true)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace} Cubic meters left.");
            }
        }
    }
}
