using System;

class Room
{
    private List<SmartDevice> _roomDevices; 

    public Room(List<SmartDevice> smartDevices)
    {
        _roomDevices = smartDevices;
    }

    public void AddDevice(SmartDevice device)
    {
        _roomDevices.Add(device);
    }

    public void PowerDevice(string name, string onOff)
    {
        foreach(SmartDevice device in _roomDevices)
        {
            if(device.GetName() == name)
            {
                device.Power(onOff);
            }
        }
    }
    public void AllLights(string onOff)
    {
        foreach(SmartDevice device in _roomDevices)
        {
            
            if(device.GetTheType() == "light")
            {
                device.Power(onOff);
            }
        }
    }

    public void AllDevices(string onOff)
    {
        foreach(SmartDevice device in _roomDevices)
        {
            device.Power(onOff);
        }
    }

    public void ReportAll()
    {
        foreach(SmartDevice device in _roomDevices)
        {
            Console.WriteLine(device.DisplayDuration());
        }
    }
    public void ReportPoweredDevices()
    {
        foreach(SmartDevice device in _roomDevices)
        {
            if(device.IsOn() == true)
            {
                Console.WriteLine(device.DisplayDuration());
            }
        }
    }

    public void ReportLongest()
    {
        TimeSpan longest = DateTime.Now - DateTime.Now;
        string name = "";
        foreach(SmartDevice device in _roomDevices)
        {
            if(device.IsOn() == true)
            {
                if(device.GetDuration() > longest)
                {
                    longest = device.GetDuration();
                    name = device.GetName();
                }
            }
        }

        Console.WriteLine($"{name} has been on the longest at {_roomDevices[0].ConvertDuration(longest)}");
    }
}