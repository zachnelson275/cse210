class Fraction
{
    // attribute
    private int _top { get; set; }
    private int _bottom { get; set; }

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
    public string GetFractionString()
    {
        string result = $"{_top}/{_bottom}";
        return result;
    }
    public double GetDecimalValue()
    {
        double result = (double) _top / _bottom;
        return result;
    }
}