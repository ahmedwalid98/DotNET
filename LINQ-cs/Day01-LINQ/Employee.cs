namespace Day01;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public override bool Equals(object? obj)
    {
        return obj is Employee e &&
               ID == e.ID && Name == e.Name && Salary == e.Salary;
    }

    public override string ToString()
    {
        return $"{ID},{Name},{Salary}";
    }
}