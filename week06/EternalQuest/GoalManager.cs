using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nYou have " + _score + " points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");

            string choice = Console.ReadLine() ?? "";
            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
            else if (choice == "6") running = false;
            else Console.WriteLine("Please choose a number from 1 to 6.");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose a type: ");
        string type = Console.ReadLine() ?? "";

        Console.Write("Goal name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Goal description: ");
        string description = Console.ReadLine() ?? "";
        int points = ReadNumber("Points for each event: ", 0);

        if (type == "1") _goals.Add(new SimpleGoal(name, description, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, description, points));
        else if (type == "3")
        {
            int target = ReadNumber("How many times to complete it? ", 1);
            int bonus = ReadNumber("Bonus points when completed: ", 0);
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else { Console.WriteLine("That goal type is not valid."); return; }

        Console.WriteLine("Goal created!");
    }

    private void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0) { Console.WriteLine("You have no goals yet."); return; }

        for (int i = 0; i < _goals.Count; i++)
        {
            string mark = _goals[i].IsComplete() ? "[X]" : "[ ]";
            // Polymorphism: GetDetails() calls the matching goal class implementation.
            Console.WriteLine((i + 1) + ". " + mark + " " + _goals[i].GetDetails());
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0) { Console.WriteLine("Create a goal first."); return; }

        ListGoals();
        int number = ReadNumber("Which goal did you complete? ", 1, _goals.Count);
        Goal goal = _goals[number - 1];

        if (goal.IsComplete())
        {
            Console.WriteLine("That goal is already complete.");
            return;
        }

        // Polymorphism: each goal type changes its progress in its own RecordEvent().
        goal.RecordEvent();
        int earned = goal.GetPoints();

        if (goal is ChecklistGoal)
        {
            ChecklistGoal checklist = (ChecklistGoal)goal;
            if (checklist.IsComplete()) earned = earned + checklist.GetBonus();
        }

        _score = _score + earned;
        Console.WriteLine("You earned " + earned + " points!");
        Console.WriteLine("Your score is now " + _score + ".");
    }

    private void SaveGoals()
    {
        using (StreamWriter output = new StreamWriter("goals.txt"))
        {
            output.WriteLine(_score);
            foreach (Goal goal in _goals) output.WriteLine(goal.SaveString());
        }
        Console.WriteLine("Goals saved to goals.txt.");
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt")) { Console.WriteLine("No saved goals file was found."); return; }

        string[] lines = File.ReadAllLines("goals.txt");
        _goals.Clear();
        if (lines.Length > 0) _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "Simple")
                _goals.Add(new SimpleGoal(name, description, points, bool.Parse(parts[4])));
            else if (type == "Eternal")
                _goals.Add(new EternalGoal(name, description, points, int.Parse(parts[4])));
            else if (type == "Checklist")
                _goals.Add(new ChecklistGoal(name, description, points, int.Parse(parts[4]),
                    int.Parse(parts[5]), int.Parse(parts[6])));
        }
        Console.WriteLine("Goals loaded!");
    }

    private int ReadNumber(string prompt, int minimum, int maximum = int.MaxValue)
    {
        while (true)
        {
            Console.Write(prompt);
            string answer = Console.ReadLine() ?? "";
            int number;
            if (int.TryParse(answer, out number) && number >= minimum && number <= maximum)
                return number;
            Console.WriteLine("Please enter a valid whole number.");
        }
    }
}
