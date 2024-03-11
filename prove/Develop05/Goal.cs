using System;

abstract class Goal
{
    private string _name;
    private int _points;
    private bool _isComplete;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
    }

    public void Completed()
    {
        _isComplete = true;
    }


}