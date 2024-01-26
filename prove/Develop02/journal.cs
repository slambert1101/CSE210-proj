// this class will ask the user for an input


public class Journal
{
    
    public int Start()
    {
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Save");
        Console.WriteLine("4: Load");
        Console.WriteLine("5: Quit");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }

}