namespace Task3;

public class FinalExam<T, TU>: Exam<T, TU> where T : Question where TU : Answer
{
    public FinalExam(int numOfQuestion, DateTime exTime, Dictionary<T, TU> questionAnswer, Subject subject) : base(numOfQuestion, exTime, questionAnswer, subject)
    {
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Final Exam - Questions Only:");
        foreach (var question in QuestionAnswer.Keys)
        {
            Console.WriteLine($"{question.Header} - {question.Body}");
        }
    }
}