namespace Day3;

public class Employee
{
    #region Fields

    private int id;
    private string name;
    private int age;
    private decimal salary;

    #endregion

    #region Properties
    // alternate way for setter and getter

    public int Id
    {
        set { id = value;}
        get { return id; }
    }

    public string Name
    {
        set { name = value; }
        get { return name; }
    }

    public int Age
    {
        set { age = value; }
        get { return age; }
    }

    public decimal Salary
    {
        set { salary = value; }
        get { return salary; }
    }
    #endregion

    #region ctors

    public Employee(int _id, string _name, int _age, decimal _salary)
    {
        id = _id;
        name = _name;
        age = _age;
        salary = _salary;
    }
    public Employee() {}
    #endregion

    #region to string

    public override string ToString()
    {
        return$"Name: {name} \nAge: {age}\nSalary: {salary}";
    }

    #endregion
}