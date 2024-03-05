using System;

class Square : Shape
{

    private double _length;

    public Square(string color, double length) : base (color)
    {
        _length = length;
    }

    public override double GetArea()
    {
        double area = _length * _length;
        return area;   
    }

}