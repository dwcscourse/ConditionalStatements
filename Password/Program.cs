﻿using System;
namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string currPassword = "";

            while (password != currPassword)
            {
                currPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
