using System;

class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    protected string _type;

    public Event(string title, string description, string date, string time, Address address)
    {
        _type = "Event";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"{_address.FullAddress()}");
        Console.WriteLine();
    }

    public virtual void FullDetails()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"{_address.FullAddress()}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($"{_type}, {_title}, {_date}");
        Console.WriteLine();
    }
}