public class Breathing : Activity
{
    public void StartBreathing()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by breathing in and out slowly.");
        Console.WriteLine("Clear your mind, and get ready.");
        base.LoadingWheel(6);
    }
    public int GetBreathCycles()
    {
        double time = base.SetTimer();
        int cycles = (int)Math.Floor(time / 10);
        return cycles;
    }
    public void BreathCycle()
    {
        Console.WriteLine();
        Console.Write("Inhale");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"\rInhale {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        Console.Write("Hold");
        for (int i=0; i<7; i++)
        {
            Console.Write($"\rHold {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();

        Console.Write("Exhale");
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"\r Exhale {i}");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    public void BreathingActivity()
    {
        int cycles = GetBreathCycles();
        StartBreathing();
        for (int i = cycles; i > 0; i--)
        {
            BreathCycle();
        }
        base.EndMessage(cycles * 10);
    }
}