namespace Day01;

public static class Int32Extensions
{
    // Extension method
    public static int Mirror(this int x)
    {
        var output = x.ToString().ToCharArray();
        Array.Reverse(output);
        return int.Parse(new string(output));
    }
}