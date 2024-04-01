using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"Lecture by {_speaker}");
        base.FullDetails();
        Console.WriteLine($"Total capacity: {_capacity}");
        Console.WriteLine();
    }
}