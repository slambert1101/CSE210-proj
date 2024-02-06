

class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        this.top = 1;
        this.bottom = 1;

    }

    public Fraction(int top)
    {
        this.top = top;
        this.bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }


    public int GetNumerator()
    {
        int numerator = top;
        return numerator;
    }
    public int GetDenominator()
    {
        int denominator = bottom;
        return denominator;
    }
    public void SetDenominator(int input)
    {
        bottom = input;
    }
    public void SetNumerator(int input)
    {
        top = input;
    }

    public void GetFractionString()
    {
        string fractionString = $"{top}/{bottom}";
        Console.WriteLine(fractionString);
    }
    
    public void GetDecimalValue()
    {
        double numerator = top;
        double denominator = bottom;
        double value = numerator/denominator;
        Console.WriteLine(value);
    }

}