using System;


public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }

    public Fraction (int top)
    {
        this.top = top;
        this.bottom = 1;
    }

     public Fraction(int top, int bottom)
    {
        this.top = top;
        this.bottom = bottom;
    }

    public int GetTop()
    {
        return top;
    }

    public int GetBottom()
    {
        return bottom;
    }

    public void SetTop (int top)
    {
        this.top = top;
    }

    public void SetBottom(int bottom)
    {
        this.bottom = bottom;
    }

    public string GetFractionString()
    {
        return top + "/" + bottom;
    }

    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }

}


class Program
{
    static void Main (string[]args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
    }
}
