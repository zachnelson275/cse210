class Breathing : Activity
{
    private int _breathCycle;
    public void StartBreathing()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by breathing in and out slowly.");
        Console.WriteLine("Clear your mind, and get ready.");
        base.LoadingWheel(6);
    }
    public int GetBreathCycle()
    {
        double time = base.SetTimer();
        int cycles = (int)Math.Floor(time / 10);
        return cycles;
    }
    public void BreathingActivity()
    {

    }
}