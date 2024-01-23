namespace Day7;

class Program
{
    static void Main(string[] args)
    {
        #region Repo

        var employees = Repository.Employees;

        #endregion

        #region Filtratiom

        // var filteredEmp = Filtration.FilterPerAge(employees);
        // filteredEmp = Filtration.FilterPerSalary(employees);
        // filteredEmp = Filtration.FilterPerDept(employees);

        // var filteredEmp = Filtration.FilterPerAny(employees);
        var empDelegate = new EmpDelegate(FilterPer.PerSalary);
        // or
        empDelegate = FilterPer.PerSalary;
        // or
        empDelegate = delegate(Employee emp)
        {
            return emp.Salary > 22000;
        };
        //or
        empDelegate = (Employee tmp) =>
        {
            return tmp.Salary < 22000;
        };
        // or
        empDelegate = (tmp) =>
        {
            return tmp.Salary < 22000;
        };
        //or
        empDelegate = employee => employee.Salary == 22000;
        var filteredEmp = Filtration.FilterPerDelegate(employees, empDelegate);

        #endregion

        #region output

        foreach (var employee in filteredEmp)
        {
            Console.WriteLine(employee);
        }

        #endregion
    }
}