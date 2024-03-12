using System;

abstract class Goal
{
    private string _name;
    private int _points;
    protected bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }


    public abstract void Completed();

}