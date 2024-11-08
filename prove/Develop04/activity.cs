public class Activity
{
    protected int _timer;
    public int Menu()
    {
        Console.Clear();
        Console.Write(@"Welcome to the Mindfulness app! Please choose an activity
        
1. Breathing
2. Reflection
3. Listing
4. Quit   

");
        int choice = int.Parse(Console.ReadLine());
        return choice;
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
    public void LoadingWheel(int seconds)
    {
        int iterations = seconds / 2;
        for (int i = 0; i < iterations; i++)
        {
            Console.Write($"\r|****");
            Thread.Sleep(250);        
            Console.Write($"\r*|***");
            Thread.Sleep(250);        
            Console.Write($"\r**|**");
            Thread.Sleep(250);
            Console.Write($"\r***|*");
            Thread.Sleep(250);
            Console.Write($"\r****|");
            Thread.Sleep(250);
            Console.Write($"\r***|*");
            Thread.Sleep(250);
            Console.Write($"\r**|**");
            Thread.Sleep(250);
            Console.Write($"\r*|***");
            Thread.Sleep(250);
        }
        Console.Write("\r     \r");
    }
    public void EndMessage(int time)
    {
        Console.WriteLine($"You completed {time} seconds of this activity!");
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
    public Activity()
    {
    }
}