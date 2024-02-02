using Day02.Models2;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();
            var author = new Author
            {
                FirstName = "Ahmed",
                LastName = "Walid"
            };
            _context.Authors.Add(author);
            _context.SaveChanges();
        }
    }
}
