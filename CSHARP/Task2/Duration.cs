namespace Task2;

public class Duration
{
    #region Propertiies

    public int Hours { get; set; }
    public int Minutes { get; set; }
    public int Seconds { get; set; }

    #endregion

    #region ctors

    public Duration() {}

    public Duration(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    public Duration(int seconds)
    {
        Hours = seconds / 3600;
        seconds %= 3600;
        Minutes = seconds / 60;
        seconds %= 60;
        Seconds = seconds;
    }

    #endregion
    
    #region override System object members

    public override string ToString()
    {
        return $"Hours: {Hours}, Minutes : {Minutes}, Seconds : {Seconds}";
    }

    public override bool Equals(object? obj)
    {
        var otherDuration = (Duration)obj;
        return Hours == otherDuration.Hours && Minutes == otherDuration.Minutes && Seconds == otherDuration.Seconds;
    }

    #endregion

    #region overloading operators

    public static Duration operator +(Duration d1, Duration d2)
    {
        var newDuration = new Duration();
        newDuration.Hours = d1.Hours + d2.Hours;
        newDuration.Minutes = d1.Minutes + d2.Minutes;
        newDuration.Seconds = d1.Seconds + d2.Seconds;
        return newDuration;
    }

    public static Duration operator ++(Duration d)
    {
        if (d.Minutes == 59)
        {
            d.Hours++;
            d.Minutes = 0;
        }
        else
        {
            d.Minutes++;
        }
        var duration = new Duration();
        duration.Hours = d.Hours;
        duration.Minutes = d.Minutes;
        duration.Seconds = d.Seconds;
        return duration;
    }
    public static Duration operator --(Duration d)
    {
        if (d.Minutes == 0)
        {
            d.Hours--;
            d.Minutes = 59;
        }
        else
        {
            d.Minutes--;
        }
        var duration = new Duration();
        duration.Hours = d.Hours;
        duration.Minutes = d.Minutes;
        duration.Seconds = d.Seconds;
        return duration;
    }
    #endregion
}