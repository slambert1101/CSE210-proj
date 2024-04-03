using System;

class Swimming : Activity
{
    private double _laps; //each lap is 50 m

    public Swimming(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
        _type = "Swimming";
    }

    public override double GetDistance()
    {
        double distance = (_laps * 50) / 1000; // in km
        return Math.Round(distance, 2);
    }
    public override double GetSpeed() //in km/h
    {
        double hours = this.GetLength() / 60;
        return Math.Round(this.GetDistance() / hours, 2);
    }
    public override double GetPace()
    {
        double pace = this.GetLength() / this.GetDistance();
        return Math.Round(pace, 2);
    }

}