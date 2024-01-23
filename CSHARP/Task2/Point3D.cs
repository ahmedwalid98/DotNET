using System.Runtime.Intrinsics.X86;

namespace Task2;

public class Point3D : IComparable, ICloneable
{
    #region Properties

    public decimal X { get; set; }
    public decimal Y { get; set; }
    public decimal Z { get; set; }

    #endregion

    #region ctors

    public Point3D() {}

    public Point3D(decimal x, decimal y, decimal z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    #endregion

    #region tostring

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }

    public object Clone()
    {
        return new Point3D { X = X, Y = Y, Z = Z };
    }

    public int CompareTo(object? obj)
    {
        var right = obj as Point3D;
        if (X.CompareTo(right.X) == 0)
            return Y.CompareTo(right.Y);
        return X.CompareTo(right.X);
    }

    #endregion

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // Convert the object to a Point3D for comparison
        Point3D otherPoint = (Point3D)obj;

        // Compare individual properties for equality
        return X == otherPoint.X && Y == otherPoint.Y && Z == otherPoint.Z;
    }
}