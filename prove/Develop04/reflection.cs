class Reflection : Activity
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
        int cycles = (int)Math.Floor(time / 8);
        return cycles;
    }
    public void StartReflection()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflection Activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by reflecting on what's been going on recently");
        Console.WriteLine("Clear your mind, and get ready.");
        base.LoadingWheel(6);
    }
    public void ReflectionActivity()
    {
        int cycles = GetQuestionCycles();
        StartReflection();
        Console.Clear();
        Console.WriteLine(RandPrompt());
        LoadingWheel(6);
        for (int i = cycles; i > 0; i--)
        {
            Console.WriteLine();
            Console.WriteLine(RandQuestion());
            Thread.Sleep(8000);
        }
        EndMessage(cycles * 8);
    }
}