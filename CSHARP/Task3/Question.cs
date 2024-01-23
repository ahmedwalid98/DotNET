namespace Task3;

public class Question
{
    public string Header { get; set; }
    public string Body { get; set; }
    public int Marks { get; set; }
    public AnswerList AnswerList { get; set; }

    public Question()
    {
        
    }

    public Question(string header, string body, int marks, AnswerList answerList)
    {
        Header = header;
        Body = body;
        Marks = marks;
        AnswerList = answerList;
    }
    public virtual void Display()
    {
        Console.WriteLine($"{Header} - {Body} ({Marks} marks)");
    }

    public override string ToString()
    {
        return $"{Header} - {Body} ({Marks} marks)";
    }
}