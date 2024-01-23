namespace Task4;

public class BookFunctions
{
    public static string GetTitle (Book b)
    {
        return b.Title;
    }
    public static string GetAuthors(Book b)
    {
        return b.Authors.ToString();
    }
    public static string GetPrice(Book b)
    {
        return b.Price.ToString();
        
    }
}