using System;
using System.IO;
using System.Diagnostics;

public class Manager
{
    private int _totalPoints;
    private List<Goal> goals;
    private List<string> goalsToUse;

    public void Save()
    {
        goalsToUse.Clear();
        foreach (Goal g in goals)
        {
            string compressedGoal = g.CompressInfo() + "*!@";
            goalsToUse.Add(compressedGoal);
        }

        Console.WriteLine("What is the name of the file you'd like to save to?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string goal in goalsToUse)
            {
                outputFile.WriteLine(goal);
            }
        }
    }
    public void Load()
    {
        goalsToUse.Clear();
        Console.WriteLine("What is the name of the file you'd like to load?");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(new string[] { "*!@" }, StringSplitOptions.None);
            foreach (string part in parts)
            {
                string cleanedPart = part.Trim();
                goalsToUse.Add(cleanedPart);
            }
        }
    }
    public void DisplayGoals()
    {
        int count = 0;
        foreach (Goal g in goals)
        {
            count += 1;
            Console.WriteLine($"{count}. {g.DisplayInfo()}");
        }
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public int DisplayPoints()
    {
        return _totalPoints;
    }
    public Manager()
    {
        _totalPoints = 0;
        goals = new List<Goal>();
        goalsToUse = new List<string>();
    }
}