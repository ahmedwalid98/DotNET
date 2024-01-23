namespace task1;

public struct HiringDate: IComparable
{
    private int _day;
    private int _month;
    private int _year;

    public HiringDate(int day, int month, int year)
    {
        _day = day;
        _month = month;
        _year = year;
    }

    public int Day
    {
        get
        {
            return _day;
        }
    }
    
    public int Month
    {
        get { return _month; }
    }

    public int Year
    {
        get { return _year; }
    }
    public override string ToString()
    {
        return $"{_day}/{_month}/{_year}";
    }

    public int CompareTo(object? obj)
    {
        var right = (HiringDate) obj;
        if (Year.CompareTo(right.Year) == 0)
        {
            if (Month.CompareTo(right.Month) == 0)
                return Day.CompareTo(right.Day);

            return Month.CompareTo(right.Month);
        }
        return Year.CompareTo(right.Year);
    }
}