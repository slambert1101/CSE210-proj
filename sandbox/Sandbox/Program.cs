using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        SmartLight light = new SmartLight("kitchen light");
        SmartLight light2 = new SmartLight("hall light");
        SmartHeater heater = new SmartHeater("space heater");

        light.Power("on");

        Thread.Sleep(5000);

        //Console.WriteLine(light.DisplayDuration());
        

        light2.Power("on");

        Thread.Sleep(2000);

        
        heater.Power("on");

        List<SmartDevice> devices = new List<SmartDevice>
        {
            light, 
            light2, 
            heater
        };

        Room room = new Room(devices);
        room.AllDevices("on");
        room.ReportPoweredDevices();
        room.PowerDevice("kitchen light", "off");
        //room.ReportAll();
        room.AllLights("off");
        room.ReportPoweredDevices();

    }
}