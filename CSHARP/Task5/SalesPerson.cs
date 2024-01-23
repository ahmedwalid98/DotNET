namespace Task5;

public class SalesPerson: Employee
{
    public int AchievedTarget { get; set; }
    public bool CheckTarget (int quota)
    {
        if (quota > AchievedTarget)
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs());
            return false;
        }

        return true;
    }
}