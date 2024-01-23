namespace Task5;

public class Department
{
    public int DeptID { get; set; }
    public string DeptName { get; set; }
    List<Employee> Staff;
    public void AddStaff (Employee e)
    {
        e.EmployeeLayOff += RemoveStaff;
        Staff.Add(e);
        ///Try Register for EmployeeLayOff Event Here
    }
    ///CallBackMethod
    public void RemoveStaff (object sender ,
        EmployeeLayOffEventArgs e)
    {
        if (sender is Employee emp && (e.Cause == LayOffCause.EndYear || e.Cause == LayOffCause.OutOfVacation))
        {
            Staff.Remove(emp);
        }
    }
}