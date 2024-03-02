using System;

class ReflectionActivity : Activity
{


    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

    };

    public ReflectionActivity() : base()
    {
        _directions = @"Welcome to the reflection activity.

    This activity will help you reflect on times in your life when you have shown strength and resilience.
    This will help you recognize the power you have and how you can us it in other aspects of your life. ";

        _activityType = "Reflection";

        _prompts =
        [
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you were true to your values.",
        "Think of a time when you did something truly selfless."
        ];
        
    }



    public void GivePrompt(List<string> prompts)
    {
        string prompt = this.GetRandomPrompt(prompts);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"---- {prompt} ----");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, please press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to the experience.");
        Console.Write("You may begin in: ");
        this.CountDownTimer(5);
    }

    public void ListQuestions(List<string> questions)
    {
        DateTime end = this.GetEndTime();
        while(DateTime.Now<end)
        {
            string question = this.GetRandomPrompt(questions);
            Console.Write($">{question} ");
            this.Spinner(10);
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
        this.GivePrompt(_prompts);
        Console.Clear();
        this.ListQuestions(_questions);
        this.DisplayEndMessage();
    }


}