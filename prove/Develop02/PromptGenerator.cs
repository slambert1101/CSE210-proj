// this class will generate a prompt for the user's journal entry.

using System.Net;
using System.Xml.Serialization; 

public static class PromptGenerator
{
   
    
    public static List<string> prompts = new List<string>
    {
        "What was the best part of your day? ",
        "If you had one thing you could do over today, what would it be? ",
        "What's the biggest thing you learned today? ",
        "What was something interesting that happened today? ",
        "Who was the most interesting person you interacted with today? "
    };
    
    public static string Generate()
    {
        Random rand = new Random();

        int num = rand.Next(prompts.Count);
        string prompt = prompts[num];
        return prompt;

    }

}