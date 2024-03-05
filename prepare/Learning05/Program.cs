using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 5.5);
        Rectangle rectangle = new Rectangle("yellow", 3, 4);
        Circle circle = new Circle("green", 3);
        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }
}