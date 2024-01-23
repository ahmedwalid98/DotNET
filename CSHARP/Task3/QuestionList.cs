namespace Task3;

public class QuestionList: List<Question>
{
    
    static int filePath = 0;
    public QuestionList()
    {
        filePath++;
    }
    public void Add(Question item)
    {
        
        using (TextWriter textWriter = new StreamWriter($"../../../test-{filePath}.txt", true))
        {
           textWriter.WriteLine(item);
        }
        base.Add(item);
        
    }
}