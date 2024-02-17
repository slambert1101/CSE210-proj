using System;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5-6");
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        

        Console.Clear();
        Console.WriteLine(scripture.DisplayVerse());
            
        Console.WriteLine();

        Console.WriteLine("Press enter to continue, or type 'quit' to finish:");
        Console.Write(">");
        string choice = Console.ReadLine();
        
        
        
        while(choice != "quit")
        {
            
            
            scripture.HideRandomWords();
            
            Console.Clear();
            Console.WriteLine(scripture.DisplayVerse());
            
            Console.WriteLine();

            Console.WriteLine("Press enter to continue, or type 'quit' to finish:");
            Console.Write(">");
            choice = Console.ReadLine();
            if(scripture.GetAllHidden() == true)
            {
                choice = "quit";
            }

            

        }


        


    }
}