namespace task1;

public struct Employee : IComparable
{
    #region fields

    private int _id;
    private decimal _salary;
    private HiringDate _hiringDate;
    private Gender _gender;
    private Security _security;

    #endregion

    #region ctors

    public Employee()
    {
        
    }
    public Employee(int id, decimal salary, HiringDate hiringDate, Gender gender, Security security)
    {
        _id = id;
        _salary = salary;
        _hiringDate = hiringDate;
        _gender = gender;
        _security = security;
    }

    #endregion

    #region properties

    public int Id
    {
        set { _id = value;}
        get { return _id; }
    }

    public decimal Salary
    {
        set { _salary = value; }
        get { return _salary; }
    }

    public Gender Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }

    public HiringDate HiringDate
    {
        get { return _hiringDate;}
        set { _hiringDate = value; }
    }

    public Security Security
    {
        get { return _security; }
        set { _security = value; }
    }
    #endregion

    #region toString

    public override string ToString()
    {
        return $"Salary: {_salary:C}";
    }

    public int CompareTo(object? obj)
    {
        var right = (Employee)obj;
        return HiringDate.CompareTo(right.HiringDate);
    }

    #endregion
}