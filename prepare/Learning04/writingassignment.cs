public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public void GetWritingInformation()
    {
        string name = GetName();
        Console.WriteLine($"{_title} by {name}");
    }
}