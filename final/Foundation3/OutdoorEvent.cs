using System;

class OutdoorEvent : Event
{
    public string _forecast;
    public OutdoorEvent(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address)
    {
        _type = "Outdoor Gathering";
        _forecast = forecast;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"Outdoor Gathering");
        base.FullDetails();
        Console.WriteLine($"Weather forecast: {_forecast}");
        Console.WriteLine();
    }
}