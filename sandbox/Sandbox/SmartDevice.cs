using System;
using System.ComponentModel.DataAnnotations;

abstract class SmartDevice
{
    private string _name;

    private string _type;
    private bool _isOn;
    
    private DateTime _start;

    

    public SmartDevice(string name)
    {
        _name = name;
        _isOn = false;
        _type = "";
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetTheType()
    {
        return _type;
    }
    public void SetType(string type)
    {
        _type = type;
    }





    public void Power(string onOff)
    {
        if(onOff == "on")
        {
            if(_isOn == false)
            {
                _isOn = true;
                _start = DateTime.Now;
            }
            else
            {
                _isOn = true;
            }
        }
        else if(onOff == "off")
        {
            _isOn = false;
            
            
        }
        else
        {
            if(_isOn == false)
            {
                _isOn = true;
                _start = DateTime.Now;
            }
            else
            {
                _isOn = false;
            }
        }

    }
    public bool IsOn()
    {
        return _isOn;
    }

    public string ConvertDuration(TimeSpan duration)
    {
        int hours = duration.Hours;
        int minutes = duration.Minutes;
        int seconds = duration.Seconds;
        if(hours>0)
        {
            return $"{hours} hours, {minutes} minutes, and {seconds} seconds.";
        }
        else if(minutes>0)
        {
            return $"{minutes} minutes and {seconds} seconds.";
        }
        else
        {
            return $"{seconds} seconds.";
        }
    }
    public TimeSpan GetDuration()
    {
        if(_isOn == true)
        {
            TimeSpan _duration = DateTime.Now - _start;
            return _duration;
        }
        else
        {
            return DateTime.Now - DateTime.Now;
        }
        
        
    }
    public string DisplayDuration()
    {
        if(_isOn == true)
        {
            TimeSpan _duration = DateTime.Now - _start;
            string converted = this.ConvertDuration(_duration);
            return $"{_name} has been on for {converted}";
        }
        else
        {
            return $"{_name} is powered off.";
        }
        
        
    }


}
