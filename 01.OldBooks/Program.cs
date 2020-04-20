using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string desiredBook = Console.ReadLine();
            int booksInChelf = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int numberOfCheckedBook = 0;
            bool isBookFound = false;

            while (numberOfCheckedBook < booksInChelf)
            {
                if (input == desiredBook)
                {
                    isBookFound = true;
                    break;
                }

                input = Console.ReadLine();
                numberOfCheckedBook++;

            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {numberOfCheckedBook} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {numberOfCheckedBook} books.");
            }
        }
    }
}
