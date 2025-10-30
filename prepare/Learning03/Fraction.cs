using System;
using System.Diagnostics;

public class Fraction
{
    private int _top;

    private int _bottom;

    public Fraction()
    {
        _bottom = 1;
        _top = 1;
    }

    public Fraction(int wholeNumber)
    {
        _bottom = 1;
        _top = wholeNumber;
    }

    public Fraction(int top, int bottom)
    {
        _bottom = bottom;
        _top = top;
    }

    public int GetTopNumber()
    {
        return _top;
    }

    public void SetTopNumber(int top)
    {
        _top = top;
    }

    public int GetBottomNumber()
    {
        return _bottom;
    }

    public void SetBottomNumber(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}