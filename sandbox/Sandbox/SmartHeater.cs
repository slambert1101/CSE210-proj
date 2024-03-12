using System;

class SmartHeater : SmartDevice
{

    private int _temperature;

    public SmartHeater(string name) : base(name)
    {
        this.SetName(name);
        this.SetType("heater");
    }

    public void SetTemp(int temp)
    {
        _temperature = temp;
    }

    public int GetTemp()
    {
        return _temperature; 
    }
}