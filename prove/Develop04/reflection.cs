public class Reflection : Activity
{
    private string[] _prompts;
    private string[] _questions;
    public string RandPrompt()
    {
        int upper = _prompts.Length;
        int promptIndex = Random.Shared.Next(0, upper);
        return _prompts[promptIndex];
    }
    public string RandQuestion()
    {
        int upper = _questions.Length;
        int promptIndex = Random.Shared.Next(0, upper);
        return _questions[promptIndex];
    }
    public int GetQuestionCycles()
    {
        double time = base.SetTimer();
        int cycles = (int)Math.Floor(time / 10);
        return cycles;
    }
    public void StartReflection()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflection Activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        base.LoadingWheel(6);
    }
    public void ReflectionActivity()
    {
        int cycles = GetQuestionCycles();
        StartReflection();
        base.LoadingWheel(6);
        Console.Clear();
        Console.WriteLine(RandPrompt());
        base.LoadingWheel(6);
        for (int i = cycles; i > 0; i--)
        {
            Console.WriteLine();
            Console.WriteLine(RandQuestion());
            Thread.Sleep(8000);
        }
        base.EndMessage(cycles * 10);
    }
    public Reflection(string[] prompts, string[] questions)
    {
        _prompts = prompts;
        _questions = questions;
    }
}