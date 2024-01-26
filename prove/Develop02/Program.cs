using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal program!");
        List<string> entries = new List<string>{};

        int response = journal.Start();
        

        while (response != 5)
        {
            if (response == 1)
            {
                //this will give user a prompt and they can write
                PromptGenerator newprompt = new PromptGenerator();
                Entry entry = new Entry();
                entry._prompt = newprompt.Generate();
                string newentry = entry.Ask();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
                string completeEntry = $"Date: {dateText}- Prompt: {entry._prompt} {newentry}";

                entries.Add(completeEntry);
            }

            else if (response == 2)
            {
                //this will display all journal entries
                entries.ForEach(Console.WriteLine);
            }

            else if (response == 3)
            {
                //this will save the entries
                Save save = new Save();
                save._fileList = entries;
                save.Ask();
                save.SaveFile();
                
            }

            else if (response == 4)
            {
                //this will load previous entries
            }

            else
            {
                Console.WriteLine("Please input a valid option.");
            }

            response = journal.Start();





        }



        // Entry entry = new Entry();
        // entry.Ask();
    }
}