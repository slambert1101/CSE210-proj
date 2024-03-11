using System;

class SmartHeater : SmartDevice
{

    private int _temperature;

    public SmartHeater(string name) : base(name)
    {
        this.SetName(name);
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