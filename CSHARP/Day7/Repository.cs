namespace Day7;

public static class Repository
{
    public static List<Employee> Employees { get; set; }

    static Repository()
    {
        Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ahmed", Age = 23, Salary = 25000, DeptId = 10 },
            new Employee { Id = 2, Name = "Mohammed", Age = 25, Salary = 20000, DeptId = 30 },
            new Employee { Id = 3, Name = "Yamen", Age = 27, Salary = 2000, DeptId = 10 },
            new Employee { Id = 4, Name = "menna", Age = 23, Salary = 15000, DeptId = 20 },
            new Employee { Id = 5, Name = "Abuads", Age = 25, Salary = 10000, DeptId = 10 },
            new Employee { Id = 6, Name = "Mohammed", Age = 26, Salary = 11000, DeptId = 20 },
            new Employee { Id = 7, Name = "Abdullah", Age = 28, Salary = 30000, DeptId = 30 },
            new Employee { Id = 8, Name = "Reda", Age = 30, Salary = 22000, DeptId = 20 },
            new Employee { Id = 9, Name = "Amr", Age = 20, Salary = 5000, DeptId = 30 },
        };
    }
}