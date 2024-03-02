using System;

class ListingActivity : Activity
{

    public ListingActivity() : base()
    {
        _directions = @"Welcome to the listing activity.

    This activity will help you reflect on the good things in your life by having
    you list as many things as you can in a certain area.";


        _activityType = "listing";

        _prompts = 
        [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
    }


    public void GivePrompt(List<string> prompts)
    {
        string prompt = this.GetRandomPrompt(prompts);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---- {prompt} ----");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        this.CountDownTimer(5);
    }

    public void Listing()
    {
        int count = 0;
        DateTime end = this.GetEndTime();
        while(DateTime.Now<end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        if(count == 1)
        {
            Console.WriteLine($"You listed {count} item!");
        }
        else
        {
            Console.WriteLine($"You listed {count} items!");
        }
    }


    public override void Play()
    {
        Console.Clear();
        this.DisplayDirections();
        this.AskTime();
        Console.Clear();
        this.GetReady();
        this.GivePrompt(_prompts);
        Console.WriteLine();
        this.Listing();
        this.DisplayEndMessage();
    }






}