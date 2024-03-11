using System;

class SmartLight : SmartDevice
{
    private string _color;
    public SmartLight(string name) : base(name)
    {
        this.SetName(name);
        this.SetType("light");
        _color = "White";
    }

    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }


}