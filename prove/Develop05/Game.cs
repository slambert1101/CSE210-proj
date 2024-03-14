using System;
using System.Net;

class Game
{
    private List<Goal> _goals = [];
    private int _score;

    public Game()
    {
        _score = 0;
        _goals = [];
    }

    public int DisplayScore()
    {
        return _score;
    }
    public List<Goal> DisplayGoals()
    {
        return _goals;
    }

    public int Menu()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create new goal");
        Console.WriteLine("   2. List goals");
        Console.WriteLine("   3. Save goals");
        Console.WriteLine("   4. Load goals");
        Console.WriteLine("   5. Record event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
        int response = int.Parse(Console.ReadLine());
        return response;
    }

    public void AddGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("   1. Simple goal");
        Console.WriteLine("   2. Eternal goal");
        Console.WriteLine("   3. Checklist goal");
        Console.Write("Which type of goal would you like to create? ");
        int response = int.Parse(Console.ReadLine());
        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if(response == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        if(response == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        if(response == 3)
        {
            Console.Write("How many times does this goal need to be completed for a bonus? ");
            int quota = int.Parse(Console.ReadLine());
            Console.Write("How many points is the bonus? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, quota);
            _goals.Add(checklistGoal);

        }
        

    }

    public void DisplayAllGoals()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i+1}. {this.checkbox(goal.GetStatus())} {_goals[i].GetName()} ({_goals[i].GetDescription()})");
            i+=1;
        }
    }

    public void SaveFile()
    {

    }

    public void LoadFile()
    {

    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        int i = 0;
        foreach(Goal goal in _goals)
        {
            if(goal.GetStatus() == false)
            {
                Console.WriteLine($"{i+1}. {_goals[i].GetName()}");  
            }
            i+=1;
        }
        Console.Write("Which goal did you accomplish? ");
        int response = int.Parse(Console.ReadLine());
        _goals[response-1].Completed();
        _score = _score + _goals[response-1].GetPoints();
        Console.WriteLine($"Congratulations! you have earned {_goals[response-1].GetPoints()}");
        Console.WriteLine($"You now have {_score} points.");

    }
    
    public string checkbox(bool n)
    {
        if(n == false)
        {
            return "[ ]";
        }
        else
        {
            return "[x]";
        }
    }

}