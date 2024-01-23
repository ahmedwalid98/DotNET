namespace Day8;

public struct Location
{
   

  

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Location()
    {
        X = Z = Y = 0;
    }

    public Location(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override bool Equals(object? obj)
    {
        return obj is Location other && X == other.X && Y == other.Y && Z == other.Z;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public static bool operator ==(Location right, Location left)
    {
        return right.Equals(left);
    }

    public static bool operator !=(Location right, Location left)
    {
        return !(right == left);
    }

    public static Location operator -(Location right, Location left)
    {
        return new Location { X = right.X - left.X, Y = right.Y - left.Y, Z = right.Z - left.Y };
    }

    public override string ToString()
    {
        return $"{X}:{Y}:{Z}";
    }
}