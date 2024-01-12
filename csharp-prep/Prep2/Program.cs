using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letter = "an F.";

        if (grade >= 90)
        {
            letter = "an A.";
        }
        else if (grade >= 80)
        {
            letter = "a B.";
        }
        else if (grade >= 70)
        {
            letter = "a C.";
        }
        else if (grade >= 60)
        {
            letter = "a D.";
        }
        else
        {
            letter = "an F.";
        }

        Console.WriteLine($"You received {letter}");

        if (grade >=70)
        {
            Console.WriteLine("Congradulations on passing!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

       
    }
}