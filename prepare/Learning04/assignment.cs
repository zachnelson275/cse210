public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetName()
    {
        return _studentName;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }
}