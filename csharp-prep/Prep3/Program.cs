using System;

class Program
{
    static void Main(string[] args)
    {
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        
        Console.WriteLine("Guess the magic number between 1 and 100!");
    

        int guess = magicNumber + 1;
        do
        {
            Console.Write("What is your guess? ");
            string response = Console.ReadLine();
            guess = int.Parse(response);


            if(guess > magicNumber)
            {
                Console.WriteLine("lower");
            }

            if(guess < magicNumber)
            {
                Console.WriteLine("higher");
            }

            if(guess == magicNumber)
            {
                Console.WriteLine("That is correct.");
            }


        } while (guess != magicNumber);


    }
}