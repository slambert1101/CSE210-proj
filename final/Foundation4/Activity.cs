using System;

class Activity
{
    private double _length;  //in minutes
    private string _date;
    protected string _type;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }


    public double GetLength()
    {
        return _length;
    }


    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min)- Distance: {this.GetDistance()} km, Speed: {this.GetSpeed()} km/h, Pace: {this.GetPace()} min/km";
    }

}