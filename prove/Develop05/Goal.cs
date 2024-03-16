using System;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _points = points;
        _isComplete = false;
        _description = description;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string descirption)
    {
        _description = descirption;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool GetStatus()
    {
        return _isComplete;
    }
    public void SetStatus(bool y)
    {
        _isComplete = y;
    }
    public abstract void Completed();

    public abstract string GetStringRep();
    public virtual int GetCount()
    {
        return 0;
    }
    public virtual int GetQuota()
    {
        return 0;
    }

}