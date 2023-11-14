public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }
    public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }
    public int GetTopNumber()
    {
        return _topNumber;
    }
    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }
    public int GetBottomNumber()
    {
        return _bottomNumber;
    }
    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    public string GetFractionString()
    {
        string topNumberString = Convert.ToString(_topNumber);
        string bottomNumberString = Convert.ToString(_bottomNumber);
        return  topNumberString + "/" + bottomNumberString;
    }
    public double GetDecimalValue()
    {
        double topNumberDouble = Convert.ToDouble(_topNumber);
        double bottomNumberDouble = Convert.ToDouble(_bottomNumber);
        return topNumberDouble / bottomNumberDouble;
    }
}
