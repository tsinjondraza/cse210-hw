public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 0;
        _bottomNumber = 1;
    }
    public Fraction(int topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public void SetTopNumber(int number)
    {
        _topNumber = number;
    }
    public int GetBottomNumber()
    {
        return _bottomNumber;
    }
    public void SetBottomNumber(int digitNumber)
    {
        _bottomNumber = digitNumber;
    }
    public string GetFractionString()
    {
        string text = $"{_topNumber}/{_bottomNumber}";
        return text;
    }
    public double GetFractionDouble()
    {
        double fraction = (double)_topNumber / (double)_bottomNumber;
        return fraction;
    }
    

    
}