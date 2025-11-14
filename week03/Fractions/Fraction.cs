using System.Runtime.CompilerServices;

public class Fraction
{
    private int _top;
    private int _bottom;
    

    // Purpose of a constructor: Set default values or values provided when creating the object.
    public Fraction()
    {
       _top = 1;
       _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }
    
    public void SetTop(int top)
    {
       _top = top; 
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {   
        string completeFraction =  $"{GetTop()}/{GetBottom()}";
        return completeFraction;
    }
    public double GetDecimalValue()
    {
        double result = (double)GetTop() / GetBottom();
        return result;
    }
}
