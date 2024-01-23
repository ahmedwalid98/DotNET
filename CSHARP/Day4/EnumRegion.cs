namespace Day4;

public enum Colors
{
    White = 1,
    Red = 2,
    Black = 4,
    Yellow = 8,
}

[Flags] // represent values as bits in memory
public enum NewColors
{
    White = 1,
    Red = 2,
    Black = 4,
    Yellow = 8,
}

[Flags]
public enum Permission
{
    Read = 1,
    Write = 2,
    Execute = 4,
    Admin = 7,
    Delete = 8,
    Root = 15,
}