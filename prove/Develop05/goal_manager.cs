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
            string compressedGoal = g.CompressInfo();
            goalsToUse.Add(compressedGoal);
        }

        Console.WriteLine("What is the name of the file you'd like to save to?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
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

        int points = int.Parse(lines[0].Replace(":", ""));
        _totalPoints = points;

        lines = lines.Where((val, idx) => idx != 0).ToArray();

        foreach (string line in lines)
        {
            string[] data = line.Split([":"], StringSplitOptions.None);
            string workable = data[1];
            string[] elements = workable.Split("%,");

            if (data[0] == "Simple Goal")
            {
                Simple simple = new Simple(elements[0], elements[1], int.Parse(elements[2]), bool.Parse(elements[3]));
                goals.Add(simple);
            }
            else if (data[0] == "Eternal Goal")
            {
                Eternal eternal = new Eternal(elements[0], elements[1], int.Parse(elements[2]));
                goals.Add(eternal);
            }
            else if (data[0] == "Checklist Goal")
            {
                Checklist checklist = new Checklist(elements[0], elements[1], int.Parse(elements[2]), int.Parse(elements[3]), int.Parse(elements[4]));
                goals.Add(checklist);
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