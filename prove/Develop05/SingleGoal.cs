using System;

class SingleGoal : Goal
{
    public SingleGoal(string name, int points) : base(name, points)
    {
        this.SetName(name);
        this.SetPoints(points);
    }


    public override void Completed()
    {
        _isComplete = true;
    }

}