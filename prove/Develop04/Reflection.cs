using System;

class ReflectionActivity : Activity
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you were true to your values.",
        "Think of a time when you did something truly selfless."
    };


    private List<string> _questions = new List<string>
    {
        
    };

    public ReflectionActivity() : base()
    {
        _directions = @"Welcome to the reflection activity.

    This activity will help you reflect on times in your life when you have shown strength and resilience.
    This will help you recognize the power you have and how you can us it in other aspects of your life. ";

        _activityType = "Reflection";
        
    }





    public override void Play()
    {
     this.GetRandomPrompt(_prompts);
    }


}