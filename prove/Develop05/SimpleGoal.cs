using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        this.SetName(name);
        this.SetPoints(points);
    }


    public override void Completed()
    {
        _isComplete = true;
    }

}