using System;

class ChecklistGoal : Goal
{
    private int _bonus;
    private int _quota;

    private int _count;
    public ChecklistGoal(string name, string description, int points, int bonus, int quota) : base(name, description, points)
    {
        this.SetName(name);
        this.SetPoints(points);
        _bonus = bonus;
        _quota = quota;
        _count = 0;
    }


    public override void Completed()
    {
        _count+=1;

        if(_count < _quota)
        {
            _isComplete = false;
        }
        else
        {
            _isComplete = true;
            this.SetPoints(_bonus);
        }
    }

}