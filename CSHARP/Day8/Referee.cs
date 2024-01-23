namespace Day8;

public class Referee
{
    public string Name { get; set; }

    public void Observe(Location loc)
    {
        Console.WriteLine($"Referee: {Name} is observing {loc}");
    }
}