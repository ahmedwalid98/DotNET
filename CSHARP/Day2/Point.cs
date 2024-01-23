namespace day2;

internal struct Point
{
    private int _x;
    private int _y;

    public Point()
    {
        _x = _y = 0;
    }

    public void SetX(int x)
    {
        _x = x;
    }

    public void SetY(int y)
    {
        _y = y;
    }

    public int GetX()
    {
        return _x;
    }

    public int GetY()
    {
        return _y;
    }

    public override string ToString()
    {
        return $"({_x},{_y})";
    }
}