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
            string[] parts = line.Split(["*!@"], StringSplitOptions.None);
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
    public void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("Which goal would you like to complete?  ");
        int selection = int.Parse(Console.ReadLine()) - 1;
        int points = goals[selection].ProgressEvent();
        AddPoints(points);
    }
    public void AddSimple()
    {
        Console.WriteLine("What is the name of this goal?  ");
        string name = Console.ReadLine();
        Console.WriteLine("Write a little description of this goal:  ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?  ");
        int points = int.Parse(Console.ReadLine());

        Simple simple = new Simple(name, description, points);

        goals.Add(simple);
    }
    public void AddEternal()
    {
        Console.WriteLine("What is the name of this goal?  ");
        string name = Console.ReadLine();
        Console.WriteLine("Write a little description of this goal:  ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?  ");
        int points = int.Parse(Console.ReadLine());

        Eternal eternal = new Eternal(name, description, points);

        goals.Add(eternal);
    }
    public void AddChecklist()
    {
        Console.WriteLine("What is the name of this goal?  ");
        string name = Console.ReadLine();
        Console.WriteLine("Write a little description of this goal:  ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?  ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many time would you like to complete this goal?  ");
        int timesForBonus = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points is your goal worth?  ");
        int bonusPoints = int.Parse(Console.ReadLine());

        Checklist checklist = new Checklist(name, description, points, bonusPoints, timesForBonus);

        goals.Add(checklist);
    }
    public Manager()
    {
        _totalPoints = 0;
        goals = new List<Goal>();
        goalsToUse = new List<string>();
    }
}