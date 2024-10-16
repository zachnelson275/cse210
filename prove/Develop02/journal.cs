using System;

public class Journal {
    public List<string> entryList = new List<string>();
    public string[] promptList = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I could do over one thing today, what would it be?", "What is one thing I learned today?", "Who did I serve today?"];

    public void storeInList(string combinedEntry) {
        entryList.Add(combinedEntry);
    }
    public void displayEntryList() {
        if (entryList.Count == 0)
        {
            Console.WriteLine("Your Journal is empty");
        }
        else
        {
            foreach (string item in entryList)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}