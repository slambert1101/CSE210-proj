// this class will give user a prompt and ask for
//journal entry.

using System.Security.Cryptography;
using Microsoft.VisualBasic;

public class Entry
{

    
     public string _prompt;

    public string Ask()
    {
        Console.Write($"{_prompt}");
        string response = Console.ReadLine();
        return response;
    }
}