namespace Task3;

public class Subject
{
    public string SubjectName { get; set; }
    public string SubjectCode { get; set; }

    public Subject(string subjectName, string subjectCode)
    {
        SubjectName = subjectName;
        SubjectCode = subjectCode;
    }
}