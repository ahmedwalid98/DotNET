namespace Task3;

public class Exam<TQuestion, TUQuestion> where TQuestion: Question where TUQuestion : Answer
{
    public int NumOfQuestion { get; set; }
    public DateTime ExTime { get; set; }
    public Dictionary<TQuestion, TUQuestion> QuestionAnswer { get; set; }
    public Subject Subject { get; set; }

    public Exam(int numOfQuestion, DateTime exTime, Dictionary<TQuestion, TUQuestion> questionAnswer, Subject subject)
    {
        NumOfQuestion = numOfQuestion;
        ExTime = exTime;
        QuestionAnswer = questionAnswer;
        Subject = subject;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Exam Time: {ExTime}");
        Console.WriteLine($"Number of Questions: {NumOfQuestion}");
        Console.WriteLine($"Subject: {Subject.SubjectName}");
    }
}