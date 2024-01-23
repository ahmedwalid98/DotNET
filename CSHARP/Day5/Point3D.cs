namespace Day5;

public class Point3D: Point2D
{
    #region proberties

    public int Z { get; set; }

    #endregion

    #region ctor

    public Point3D() {}

    public Point3D(int x, int y, int z): base(x, y)
    {
        Z = z;
    }

    #endregion
    
    
}