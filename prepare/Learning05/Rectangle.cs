using System;

class Rectangle : Shape
{

    private double _width;
    private double _hight;

    public Rectangle(string color, double width, double hight) : base (color)
    {
        _width = width;
        _hight = hight;
    }

    public override double GetArea()
    {
        double area = _width * _hight;
        return area;
    }

}