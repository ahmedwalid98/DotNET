namespace Day7;

public static class FilterPer
{
    public static bool PerSalary(Employee employee)
    {
        return employee.Salary > 21000;
    }

    public static bool PerAge(Employee employee)
    {
        return employee.Age > 24;
    }
}