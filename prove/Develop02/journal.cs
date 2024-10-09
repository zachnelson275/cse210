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
}