using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Ask for the user's name
            Console.Write("What's your name? ");
            string userName = Console.ReadLine();

            // Personal greeting
            Console.WriteLine($"Nice to meet you, {userName}! Welcome to the course.");
        }
    }
}