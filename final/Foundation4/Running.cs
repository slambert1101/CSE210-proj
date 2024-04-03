using System;

class Running : Activity
{
    private double _distance; //in Kilometers

    public Running(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
        _type = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed() //in km/h
    {
        double hours = this.GetLength() / 60;
        return Math.Round(_distance / hours, 2);
    }
    public override double GetPace()
    {
        double pace = this.GetLength() / _distance;
        return Math.Round(pace, 2);
    }
}