namespace Day8;

public class Ball
{
    public string Name { get; set; }
    private Location location;

    public Location Location
    {
        get => location;
        set
        {
            if (location != value)
            {
                var delta = value - location;
                BallHasMoved?.Invoke(delta);
            }
        }
    }

    public Ball()
    {
        
    }

    public Ball(string name)
    {
        Name = name;
    }

    public event Action<Location> BallHasMoved;
}