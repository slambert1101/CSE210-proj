using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal program!");
        List<string> entries = new List<string>{};
        List<Entry> realEntries = new List<Entry>();

        int response = journal.Start();
        

        while (response != 5)
        {
            if (response == 1)
            {
                //this will give user a prompt and they can write
                
                Entry entry = new Entry();
                
                string newentry = entry.Ask();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                
                string completeEntry = $"Date: {dateText}- Prompt: {entry._prompt} {newentry}";

                entries.Add(completeEntry);
                
            }

            else if (response == 2)
            {
                //this will display all journal entries
                Console.WriteLine();
                entries.ForEach(Console.WriteLine);
                Console.WriteLine();
            }

            else if (response == 3)
            {
                //this will save the entries
                SaveFile save = new SaveFile();
                save._fileList =  entries;
                save.Ask();
                save.Save();
                
            }

            else if (response == 4)
            {
                //this will load previous entries
                SaveFile save = new SaveFile();
                save.Ask();
                entries = SaveFile.LoadFile();
                


            }

            else
            {
                Console.WriteLine("Please input a valid option.");
            }

            response = journal.Start();





        }



    
    }
}