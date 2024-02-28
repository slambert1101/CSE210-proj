using System;

class Activity
{
    private int _time;
    protected string _activityType;
    protected string _directions;

    
    
    
    public Activity()
    {

    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well Done!");
        this.Spinner(2);
        Console.WriteLine($"You have completed another {_time} seconds of the {_activityType} activity.");
        this.Spinner(3);
    }

    public void DisplayDirections()
    {
        Console.WriteLine(_directions);
    }

    public void Spinner(int i)
    {
        
        while(i>0)
        {
        
        Console.Write("|");
        Thread.Sleep(400);
        Console.Write("\b \b");

        Console.Write("<");
        Thread.Sleep(400);
        Console.Write("\b \b");

        Console.Write("-");
        Thread.Sleep(400);
        Console.Write("\b \b");

        Console.Write(">");
        Thread.Sleep(400);
        Console.Write("\b \b");


        i--;
        }

        
    

    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        this.Spinner(2);
        Console.WriteLine();
    }
    
    public void AskTime()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
    }

    public DateTime GetEndTime()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        return endTime;
    }

    public string GetRandomPrompt(List<string> list)
    {
        Random rand = new Random();

        int num = rand.Next(list.Count);
        string prompt = list[num];
        return prompt;
    }
    


    public virtual void Play()
    {
        Console.Clear();
        this.DisplayDirections();
        this.AskTime();
        this.DisplayEndMessage();

    }
    

}