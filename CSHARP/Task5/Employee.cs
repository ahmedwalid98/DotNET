namespace Task5;

public class Employee
{
    public event
        EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
    protected virtual void OnEmployeeLayOff
        (EmployeeLayOffEventArgs e)
    {
        EmployeeLayOff?.Invoke(this, e);
    }
    public int EmployeeID { get; set; }
    public DateTime BirthDate { get; set; }
    public int VacationStock
    {
        get;
        set;
    }
    public bool RequestVacation (DateTime from , DateTime to)
    {
        var diff = from.Day - to.Day;
        if (diff < VacationStock)
        {
            Console.WriteLine("Vacation is approved");
            VacationStock -= diff;
            return true;
        }
        else
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs{Cause = LayOffCause.OutOfVacation});
            return false;
        }
    }
    public void EndOfYearOperation ()
    {
        var diff = DateTime.Now.Year - BirthDate.Year;
        if (diff > 60)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs {Cause = LayOffCause.EndYear});
        }
    }
}
public enum LayOffCause
{
    OutOfVacation,
    EndYear
}
public class EmployeeLayOffEventArgs
{
    public LayOffCause Cause { get; set; }
}