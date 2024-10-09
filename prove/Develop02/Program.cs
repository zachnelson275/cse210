using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Journal journal = new Journal();
        string[] prompts = journal.promptList;
        string[] entries = journal.entryList;
        int choice = 0;
        do {
            Console.WriteLine("Welcome to your Journal!");
            Console.Write(@"Please select an option: 

1. New Entry
2. Display Journal
3. Save to File
4. Load from File
5. Quit
            ");
            
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entry newEntry = new Entry();
                string randomPrompt = Entry.randomizePrompt(prompts);
                Console.WriteLine(randomPrompt);
                newEntry.input = Console.ReadLine();
                newEntry.CurrentDate = DateTime.Now;
                string combinedEntry = Entry.combineString(randomPrompt, newEntry.CurrentDate, newEntry.input);
                entries.Append(combinedEntry); 
            }
            else if (choice == 2)
            {
                journal.displayEntryList(entries);
            }
        }
        while (choice != 5);
    }
}