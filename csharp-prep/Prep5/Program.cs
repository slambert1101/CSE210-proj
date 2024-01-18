using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int x)
        {
            int numberSquared = x * x;
            return numberSquared;
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");

        }

        DisplayWelcome();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int numberSquared = SquareNumber(favNumber);
        DisplayResult(name, numberSquared);
    }
}