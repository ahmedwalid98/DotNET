namespace Day5;

public class Employee: IComparable, ICloneable
{
    public int Ssn { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public Department Department { get; set; }

    public Employee()
    {
        Ssn = 1;
        Name = "Ahmed";
        Age = 23;
        Gender = Gender.Male;
        Department = new Department();

    }

    public Employee(int ssn, string name, int age, Gender gender, Department department)
    {
        Ssn = ssn;
        Name = name;
        Age = age;
        Gender = gender;
        Department = department;
    }

    public override string ToString()
    {
        return $"{Ssn},{Name},{Age},{Gender},{Department}";
    }

    public int CompareTo(object? obj)
    {
        Employee right = obj as Employee;
        return Department.CompareTo(right.Department);
    }

    public object Clone()
    {
        return new Employee { Ssn = Ssn, Age = Age, Name = Name, Department = Department, Gender = Gender };
    }
}