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

            else if (choice == 3)
            {
                Console.WriteLine("What is the name of the file you'd like to save to?");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(entries);
                }
            }

            else if (choice == 4)
            {
                entries = [];
                Console.WriteLine("What is the name of the file you'd like to load?");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(new string[] { "%#$" }, StringSplitOptions.None);
                    foreach (string part in parts)
                    {
                        string cleanedPart = part.Trim();
                        entries.Append(cleanedPart);
                    }
                }
            }
        }
        while (choice != 5);
    }
}