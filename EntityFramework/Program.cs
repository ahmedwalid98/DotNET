namespace EntityFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var employee = new Employee
            {
                Name = "Ahmed"
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}
