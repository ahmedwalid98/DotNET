namespace Task3;

public class ChooseOneQuestion: Question
{
    public string[] Options { get; set; }
    public ChooseOneQuestion(string header,  string body,int marks, string[] options, AnswerList answerList)
        : base(header, body, marks, answerList)
    {
        Options = options;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Options:");
        foreach (var option in Options)
        {
            Console.WriteLine($"- {option}");
        }
    }
}