class Fraction
{
    // attribute
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int top)
    {
        _top = top;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
}