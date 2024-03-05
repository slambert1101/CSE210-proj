using System;

abstract class SmartDevice
{
    private string _name;

    private bool _isOn;

    private int _duration;

    public SmartDevice(string name)
    {
        _name = name;
        _isOn = false;
    }

    public string GetName()
    {
        return _name;
    }

    public void Power()
    {
        if(_isOn == false)
        {
            _isOn = true;
            DateTime start = DateTime.Now;
        }
        else
        {
            _isOn = false;
            
        }

    }


}
