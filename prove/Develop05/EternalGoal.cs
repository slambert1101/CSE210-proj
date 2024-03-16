using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        this.SetName(name);
        this.SetPoints(points);
    }


    public override void Completed()
    {
        _isComplete = false;
    }

    public override string GetStringRep()
    {
        return $"EternalGoal:{this.GetName()}<.>{this.GetDescription()}<.>{this.GetPoints()}<.>{this.GetStatus()}";
    }

}