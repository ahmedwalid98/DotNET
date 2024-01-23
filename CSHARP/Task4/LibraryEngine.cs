namespace Task4;
public delegate string BookDel(Book b);
public class LibraryEngine
{
    public static void ProcessBooks ( List<Book> bList
        ,BookDel fPtr)
    {
        foreach (Book b in bList)
        {
            Console.WriteLine(fPtr(b));
        }
    }
}