using System;

class Program
{
    static void Main(string[] args)
    {
        string[] reflectionPrompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.", "Think of a time when you did something above and beyond what was expected of you."];
        string[] reflectionQuestions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?", "If you could go back in time and redo this experience, what would you change?"];
        string[] listingPrompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?", "What have you enjoyed doing this past month?"];
        Activity activity = new Activity();
        int choice = activity.Menu();
        while (choice != 4)
        {
            if (choice == 1)
            {
                Breathing breathing = new Breathing();
                breathing.BreathingActivity();
            }
            else if (choice == 2)
            {
                Reflection reflection = new Reflection(reflectionPrompts, reflectionQuestions);
                reflection.ReflectionActivity();
            }
            else if (choice == 3)
            {
                Listing listing = new Listing(listingPrompts);
                listing.ListingActivity();
            }
            choice = activity.Menu();
        }
    }
}