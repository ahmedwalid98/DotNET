namespace Task3;

public class PracticalExam<T, TU>: Exam<T, TU> where T : Question where TU : Answer
{
    public PracticalExam(int numOfQuestion, DateTime exTime, Dictionary<T, TU> questionAnswer, Subject subject) : base(numOfQuestion, exTime, questionAnswer, subject)
    {
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine("Practice Exam - Correct Answers:");
        foreach (var keyValuePair in QuestionAnswer)
        {
            Console.WriteLine($"{keyValuePair.Key.Header}: {keyValuePair.Value.Answers}");
            
        }
    }
}