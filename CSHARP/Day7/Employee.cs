namespace Day7;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? Age { get; set; }
    public decimal? Salary { get; set; }
    public int? DeptId { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Age: {Age}, Salary: {Salary}, DeptId: {DeptId}";
    }
}