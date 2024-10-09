using System;

public class Journal {
    public string[] entryList = [];
    public void storeInList(string combinedEntry, string[] entryList) {
        entryList.Append(combinedEntry);
    }
    public void displayEntryList(string[] entryList) {
        foreach (string item in entryList)
        {
            Console.WriteLine(item);
            Console.WriteLine();
        }
    }
    public string[] promptList = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I could do over one thing today, what would it be?", "What is one thing I learned today?", "Who did I serve today?"];
}