namespace Day5;

public class Department: IComparable
{
    public int Id { get; set; }
    public string DepName { get; set; }

    public Department()
    {
        Id = 0;
        DepName = "SD";
    }
    public Department(int id, string depName)
    {
        Id = id;
        DepName = depName;
    }

    public override string ToString()
    {
        return $"Department: {DepName}, id {Id}";
    }

    public int CompareTo(object? obj)
    {
        return Id.CompareTo((obj as Department).Id);
    }
}