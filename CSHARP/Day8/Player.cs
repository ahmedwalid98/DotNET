namespace Day8;

public class Player
{
    public string Name { get; set; }
    public string Team { get; set; }

    public Player()
    {
        
    }

    public Player(string name, string team)
    {
        Name = name;
        Team = team;
    }

    public override string ToString()
    {
        return $"Player: {Name} from team {Team} is moving";
    }

    public void Move(Location loc)
    {
        Console.WriteLine($"Player: {Name} from team {Team} is moving to {loc}");
    }
}