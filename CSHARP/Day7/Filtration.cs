namespace Day7;

public static class Filtration
{

    #region Filter V1

    // public static List<Employee> FilterPerAge(List<Employee> employees)
    // {
    //     var retVal = new List<Employee>();
    //     foreach (var employee in employees)
    //     {
    //         if (employee.Age > 26)
    //             retVal.Add(employee);
    //     }
    //     return retVal;
    // }
    //
    // public static List<Employee> FilterPerSalary(List<Employee> employees)
    // {
    //     var retVal = new List<Employee>();
    //     foreach (var employee in employees)
    //     {
    //         if (employee.Salary> 15000)
    //             retVal.Add(employee);
    //     }
    //     return retVal;
    // }
    // public static List<Employee> FilterPerDept(List<Employee> employees)
    // {
    //     var retVal = new List<Employee>();
    //     foreach (var employee in employees)
    //     {
    //         if (employee.DeptId == 30)
    //             retVal.Add(employee);
    //     }
    //     return retVal;
    // }
    #endregion

    #region Filter V2
    
    // public static List<Employee> FilterPerAny(List<Employee> employees)
    // {
    //     var retVal = new List<Employee>();
    //     foreach (var employee in employees)
    //     {
    //         if (FilterPer.PerSalary(employee))
    //             retVal.Add(employee);
    //     }
    //     return retVal;
    // }
    

    #endregion

    #region Filter V3

    public static List<Employee> FilterPerDelegate(List<Employee> employees, EmpDelegate empDelegate)
    {
        var retVal = new List<Employee>();

        foreach (var employee in employees)
        {
            if (empDelegate(employee))
                retVal.Add(employee);
        }
        
        return retVal;
    }

    #endregion
}