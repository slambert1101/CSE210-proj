using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        BreatingActivity breating = new BreatingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity();

        int option = 0;

        while(option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Breating activity");
            Console.WriteLine("     2. Reflection activity");
            Console.WriteLine("     3. Listing activity");
            Console.WriteLine("     4. Quit program");
            Console.Write("Select a choice from the menu >");
            option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                breating.Spinner(1);
                breating.Play();
            }
            else if(option == 2)
            {
                reflection.Spinner(1);
                reflection.Play();
            }
            else if(option == 3)
            {
                listing.Spinner(1);
                listing.Play();
            }
            else if(option == 4)
            {
                Console.Write("Goodbye! ");
                breating.Spinner(2);
                break;
            }
            else
            {
                Console.WriteLine("Please input valid option.");
                breating.Spinner(2);
            }


        }

    }
}