using System;

class BreatingActivity : Activity
{

    public BreatingActivity() : base()
    {
        _directions = @"Welcome to the breating activity.

    This activity will help you relax by guiding you through breathing in and out slowly. 
    Clear your mind and focus on your breathing. ";
        
        _activityType = "breathing";
    }

    

    public void BreathTimer()
    {
        DateTime end = this.GetEndTime();
        while(DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            Console.Write("OOOOOOO");
            Thread.Sleep(600);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("0OOOOOO");
            Thread.Sleep(600);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("00OOOOO");
            Thread.Sleep(600);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("000OOOO");
            Thread.Sleep(600);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("0000OOO");
            Thread.Sleep(600);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("00000OO");
            Thread.Sleep(600);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("000000O");
            Thread.Sleep(600);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("0000000");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");

            if(DateTime.Now > end)
            {
                break;
            }

            Console.Write("Breathe out... ");
            Console.Write("000000O");
            Thread.Sleep(350);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("00000OO");
            Thread.Sleep(350);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("0000OOO");
            Thread.Sleep(350);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("000OOOO");
            Thread.Sleep(350);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("00OOOOO");
            Thread.Sleep(350);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("0OOOOOO");
            Thread.Sleep(350);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.Write("OOOOOOO");
            Thread.Sleep(650);
            Console.Write("\b\b\b\b\b\b\b       \b\b\b\b\b\b\b");
            Console.WriteLine();
        }
    }

    public override void Play()
    {
        Console.Clear();
        this.DisplayDirections();
        this.AskTime();
        Console.Clear();
        this.GetReady();
        this.BreathTimer();
        Console.WriteLine();
        this.DisplayEndMessage();
    }


}