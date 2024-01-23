namespace Task3;

public class TrueOrFalseQuestion: Question
{
    public bool IsTrue { get; set; }

    public TrueOrFalseQuestion()
    {
        
    }

    public TrueOrFalseQuestion(bool isTrue, string header, string body, int marks, AnswerList answerList):
        base(header, body, marks, answerList)
    {
        IsTrue = isTrue;
    }
    
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"True/False: {IsTrue}");
    }
}