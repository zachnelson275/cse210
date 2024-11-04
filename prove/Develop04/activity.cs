class Activity
{
    private int _timer;
    private string _name;
    private string _description;
    private int _loadingSeconds;
    public void StartMessage()
    {

    }
    public int SetTimer()
    {
        Console.WriteLine("How long in seconds would you like this activity to last?  ");
        _timer = int.Parse(Console.ReadLine());
        return _timer;
    }
    public void Countdown()
    {
        Console.WriteLine("Get ready...");
        Thread.Sleep(1000);
        Console.WriteLine(3);
        Thread.Sleep(1000);
        Console.WriteLine(2);
        Thread.Sleep(1000);
        Console.WriteLine(1);
        Thread.Sleep(1000);
    }
    public void RunTimer()
    {

    }
    public void LoadingWheel(int seconds)
    {
        int iterations = (seconds * 1000) / 250;
        for (int i = 0; i < iterations; i++)
        {
            Console.WriteLine("|****");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");        
            Console.WriteLine("*|***");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");        
            Console.WriteLine("**|**");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
            Console.WriteLine("***|*");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
            Console.WriteLine("****|");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
            Console.WriteLine("***|*");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
            Console.WriteLine("**|**");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
            Console.WriteLine("*|***");
            Thread.Sleep(250);
            Console.Write("\b\b\b\b\b");
        }
    }
    public void EndMessage()
    {
        Console.WriteLine($"You completed {_timer} seconds of this activity!");
        Console.WriteLine("Well done!");
    }
}