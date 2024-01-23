namespace Task5;

public class Club
{
    public int ClubID { get; set; }
    public String ClubName { get; set; }
    List<Employee> Members;
    public void AddMember(Employee e)
    {
        ///Try Register for EmployeeLayOff Event Here
        e.EmployeeLayOff += RemoveMember;
        Members.Add(e);
    }
    ///CallBackMethod
    public void RemoveMember
        (object sender, EmployeeLayOffEventArgs e)
    {
       
        ///Employee Will not be removed from the Club if Age>60
        ///Employee will be removed from Club if Vacation Stock < 0
        if (sender is Employee emp && e.Cause == LayOffCause.OutOfVacation)
        {
            Members.Remove(emp);
        }
    }
}