namespace Day01;

class Program
{
    static void Main(string[] args)
    {
        #region Implicit type convert

        // var x = 222.55;
        // x = "ahmed"; // not valid since c# is strongly typed language

        #endregion

        #region Method Extension

        var x = 12345;
        Console.WriteLine(Int32Extensions.Mirror(x));
        Console.WriteLine(x.Mirror());

        #endregion

        #region Anonymous object

        Employee e1 = new Employee { ID = 101, Name = "ahmed", Salary = 20000 };
        Employee e2 = new Employee { ID = 101, Name = "ahmed", Salary = 20000 };

        Console.WriteLine(e1.GetType().Name);
        if (e1.Equals(e2))
            Console.WriteLine("Equals");


        // anonymous object
        var a1 = new { ID = 101, Name = "ahmed", Salary = 20000 };
        var a2 = new { ID = 101, Name = "ahmed", Salary = 20000 };
        Console.WriteLine(a1.GetType().Name);
        Console.WriteLine(a2.GetType().Name);
        
        if (a1.Equals(a2))
            Console.WriteLine("equals");

        #endregion

        #region Linq

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<string> name = new List<string> { "Ahmed", "Mohamed", "Waleed" };

        // Fluent syntax
        IEnumerable<int> output = Enumerable.Where(numbers, i => i % 2 == 0);
        
        // Extension Mehod
        var result = numbers.Where(i => i % 2 == 0);

        
        // query syntax (sql like style)
        var qeuryResult = from i in numbers
            where i % 2 == 0
            select i;

        #endregion
    }
}