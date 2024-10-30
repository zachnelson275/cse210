using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Zach", "math");
        assignment.GetSummary();

        MathAssignment math = new MathAssignment("Zach", "math", "section 7", "5-123871238");
        math.GetSummary();
        math.GetHomeworkList();

        WritingAssignment write = new WritingAssignment("Zach", "Revolutionary War", "The War");
        write.GetSummary();
        write.GetWritingInformation();
    }
}