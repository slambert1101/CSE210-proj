using System;
using System.Net;
using System.IO;

class Game
{
    private List<Goal> _goals = [];
    private int _score;

    private int _choice;

    public Game()
    {
        _score = 0;
        _goals = [];
        _choice = 0;
    }

    public int GetScore()
    {
        return _score;
    }
    public List<Goal> GetGoals()
    {
        return _goals;
    }
    public int GetChoice()
    {
        return _choice;
    }

    public void Menu()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create new goal");
        Console.WriteLine("   2. List goals");
        Console.WriteLine("   3. Save goals");
        Console.WriteLine("   4. Load goals");
        Console.WriteLine("   5. Record event");
        Console.WriteLine("   6. Edit goal list");
        Console.WriteLine("   7. Quit");
        Console.Write("Select a choice from the menu: ");
        _choice = int.Parse(Console.ReadLine());
        
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
            
            Console.Write($"{i+1}. {this.checkbox(goal.GetStatus())} {_goals[i].GetName()} ({_goals[i].GetDescription()})");
            if(goal is ChecklistGoal)
            {
                Console.Write($"  --times completed: {goal.GetCount()}/{goal.GetQuota()}");
            }
            Console.WriteLine();
            i+=1;
        }
        Console.ReadLine();
    }

    public void SaveFile()
    {
        Console.Write("What is the name of the file? ");
        string filename = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            foreach(Goal goal in _goals)
            {
                if(goal is SimpleGoal)
                {
                    outputFile.WriteLine($"SimpleGoal:{goal.GetName()}<.>{goal.GetDescription()}<.>{goal.GetPoints()}<.>{goal.GetStatus()}");
                }
                else if(goal is EternalGoal)
                {
                    outputFile.WriteLine($"EternalGoal:{goal.GetName()}<.>{goal.GetDescription()}<.>{goal.GetPoints()}");
                }
                else
                {
                    outputFile.WriteLine($"ChecklistGoal:{goal.GetName()}<.>{goal.GetDescription()}<.>{goal.GetPoints()}<.>{goal.GetStatus()}<.>{goal.GetCount()}<.>{goal.GetQuota()}");
                }
            }
        }
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
        if(_goals[response-1].GetStatus() == false)
        {
            _goals[response-1].Completed();
            _score = _score + _goals[response-1].GetPoints();
            Console.WriteLine($"Congratulations! you have earned {_goals[response-1].GetPoints()} points.");
            Console.WriteLine($"You now have {_score} points.");
            Console.WriteLine();
            Console.ReadLine();
        }
        else if(_goals[response-1].GetStatus() == true)
        {
            Console.WriteLine("This goal has already been completed. Please select another goal.");
        }
        else
        {
            Console.WriteLine("Please input valid option.");
        }
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