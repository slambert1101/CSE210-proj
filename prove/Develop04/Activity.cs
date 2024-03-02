using System;

class Activity
{
    private int _time;
    protected string _activityType;
    protected string _directions;

    protected List<string> _prompts;



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

    public void Spinner(int i) // i is how many seconds it will spin
    {
        i = i * 1000;
        while(i>0)
        {
        
        Console.Write("|");
        Thread.Sleep(400);
        Console.Write("\b \b");
        i = i-400;

        Console.Write("<");
        Thread.Sleep(400);
        Console.Write("\b \b");
        i = i-400;

        Console.Write("-");
        Thread.Sleep(400);
        Console.Write("\b \b");
        i = i-400;

        Console.Write(">");
        Thread.Sleep(400);
        Console.Write("\b \b");
        i = i-400;

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
    
    public void CountDownTimer(int i)
    {
        while(i>0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    public virtual void Play()
    {
        Console.Clear();

    }
    

}