using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        Fraction third = new Fraction(3, 4);
        Fraction fourth = new Fraction(1, 3);

        first.GetFractionString();
        first.GetDecimalValue();
        second.GetFractionString();
        second.GetDecimalValue();
        third.GetFractionString();
        third.GetDecimalValue();
        fourth.GetFractionString();
        fourth.GetDecimalValue();

    }
}