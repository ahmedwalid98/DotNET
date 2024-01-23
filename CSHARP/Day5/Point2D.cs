namespace Day5;

public class Point2D
{
    #region properties

    public int X { get; set; }
    public int Y { get; set; }

    #endregion

    #region ctors

    public Point2D() {}

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    #endregion

    public override string ToString()
    {
        return $"({X}, {Y})";
    }

    public override bool Equals(object? obj)
    {
        #region unprotective code

        // Point2D right = (Point2D)obj;
        // return X == right.X && Y == right.Y;

        #endregion

        #region unprotective code v2

        // if (obj != null)
        // {
        //     Point2D right = (Point2D)obj;
        //     return X == right.X && Y == right.Y;
        // }
        //
        // return false;

        #endregion

        #region Effective code

        // if (obj is Point2D)
        // {
        //     Point2D right = obj as Point2D;
        //     return X == right.X && Y == right.Y;
        // }

        // return false;

        #endregion

        #region more effective code
        var right = obj as Point2D;
        // if (right is null) return false;
        if (ReferenceEquals(this, right)) return true;
        if (GetType() != right.GetType()) return false;

        return X == right.X && Y == right.Y;

        #endregion
    }
}