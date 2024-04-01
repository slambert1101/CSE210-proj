using System;

class Reception : Event
{
    public string _email;
    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _type = "Reception";
        _email = email;
    }

    public override void FullDetails()
    {
        Console.WriteLine($"Reception");
        base.FullDetails();
        Console.WriteLine($"Please RSVP via email: {_email}");
        Console.WriteLine();
    }
}