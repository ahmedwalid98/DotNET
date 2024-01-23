namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        List<Book> b = new List<Book>
        {
            new Book
            {
                ISBN = "lol",
                Authors = new string[] { "Ahmed", "Mohamed" },
                Price = 24000,
                PublicationDate = DateTime.Now,
                Title = "New Book",
            }
        };
        
        LibraryEngine.ProcessBooks(b, BookFunctions.GetAuthors);
        LibraryEngine.ProcessBooks(b, BookFunctions.GetTitle);
        LibraryEngine.ProcessBooks(b, BookFunctions.GetPrice);
    }
}