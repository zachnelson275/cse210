using System;

class Program
{
    static void Main(string[] args)
    {
        Manager goalManager = new Manager();
        int choice = 0;
        do {
            Console.Clear();
            Console.WriteLine($"You have {goalManager.DisplayPoints()} points");
            Console.WriteLine();
            Console.Write(@"Menu Options:
            
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Event
6. Quite

Select a choice from the menu: ");

        choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine(@"The types of goals are: 
1. Simple Goal
2. Eternal Goal
3. Checklist Goal
Which type fo goal would you like to creat? ");
            int goalChoice = int.Parse(Console.ReadLine());
            if (goalChoice == 1)
            {
                
            }
        }
        }
        while (choice != 6);
    }
}