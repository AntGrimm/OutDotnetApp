using System;
using System.Collections.Generic;

namespace OutDotnetApp
{
    class Program
    {

        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Our Employee Database    ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }

        }
        static void Main(string[] args)
        {
            DisplayGreeting();

            var name = PromptForString("What is your name boy? ");

            int salary = PromptForInteger("What is your yearly salary (in dollars)? ");

            Console.WriteLine($"Hello, {name} you make {(salary * 0.70) / 12} dollars per month after taxes.");
        }
    }
}
