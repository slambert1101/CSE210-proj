using System;

class Cycling : Activity
{
    private double _speed; //in Km/h

    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
        _type = "Cycling";
    }

    public override double GetDistance()
    {
        double hours = this.GetLength() / 60;
        double distance = _speed * hours;
        return Math.Round(distance, 2);
    }
    public override double GetSpeed() //in km/h
    {
        return _speed;
    }
    public override double GetPace()
    {
        double pace = this.GetLength() / this.GetDistance();
        return Math.Round(pace, 2);
    }

}