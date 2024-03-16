using System;

class ChecklistGoal : Goal
{
    private int _bonus;
    private int _quota;

    private int _count;
    public ChecklistGoal(string name, string description, int points, int bonus, int count, int quota) : base(name, description, points)
    {
        this.SetName(name);
        this.SetPoints(points);
        _bonus = bonus;
        _quota = quota;
        _count = count;
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


    public override int GetCount()
    {
        return _count;
    }
    public override int GetQuota()
    {
        return _quota;
    }
    public int GetBonus()
    {
        return _bonus;
    }

    public override string GetStringRep()
    {
        return $"ChecklistGoal:{this.GetName()}<.>{this.GetDescription()}<.>{this.GetPoints()}<.>{this.GetStatus()}<.>{this.GetBonus()}<.>{this.GetCount()}<.>{this.GetQuota()}";
    }
}