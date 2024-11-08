public class Listing : Activity
{
    private string[] _prompts;
    public string RandPrompt()
    {
        int upper = _prompts.Length;
        int promptIndex = Random.Shared.Next(0, upper);
        return _prompts[promptIndex];
    }
    public void StartListing()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        base.LoadingWheel(6);
    }
    public void ListingActivity()
    {
        int count = 0;
        int time = base.SetTimer();
        StartListing();
        Console.Clear();
        Console.WriteLine(RandPrompt());
        base.LoadingWheel(6);
        DateTime end = DateTime.Now.AddSeconds(time);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count += 1;
        }
        Console.WriteLine($"You listed {count} items!");
        Thread.Sleep(1000);
        base.EndMessage(time);
    }
    public Listing(string[] prompts)
    {
        _prompts = prompts;
    }
}