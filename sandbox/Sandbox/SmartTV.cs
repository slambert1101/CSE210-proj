using System;

class SmartTV : SmartDevice
{

    public SmartTV(string name) : base(name)
    {
        this.SetName(name);
        this.SetType("TV");
    }
}