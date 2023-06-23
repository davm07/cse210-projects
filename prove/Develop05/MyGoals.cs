using System;

public class MyGoals
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public int PointsInfo
    {
        get { return _totalPoints; }
    }

    public void CreateGoals(int choice)
    {   
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if(choice == 1)
        {
            AddGoal(new SimpleGoal(goalName, goalDescription, points));
        } else if(choice == 2)
        {
            AddGoal(new EternalGoal(goalName, goalDescription, points));
        } else if(choice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int timeToAccomplish = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            AddGoal(new ChecklistGoal(goalName, goalDescription, points, timeToAccomplish, bonusPoints));
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals(int option)
    {
        int count = 1;
        foreach (var goal in _goals)
        {   
            Console.Write($"{count}. ");
            goal.DisplayGoal(option);
            count++;
        }
    }

    public void RecordGoal(int option)
    {
        int points = _goals[option -1].RecordEvent();
        _totalPoints += points;
        Console.WriteLine($"You now have {_totalPoints} points!");
    }

    public void SaveGoals(string filename)
    {   
        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string value = File.ReadLines(filename).Take(1).First();
        int points = int.Parse(value);
        _totalPoints += points;

        string [] lines = File.ReadAllLines(filename).Skip(1).ToArray(); 

        foreach (var line in lines)
        {
            string[] parts = line.Split("**");
            string goalType = parts[0];
            string goalInfo = parts[1];
            if(goalType == "SimpleGoal")
            {
                string[] goalParts = goalInfo.Split("||");
                string goalName = goalParts[0];
                string goalDescription = goalParts[1];
                int goalPoints = int.Parse(goalParts[2]);
                bool goalComplete = bool.Parse(goalParts[3]);
                AddGoal(new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete));
            } else if (goalType == "EternalGoal")
            {
                string[] goalParts = goalInfo.Split("||");
                string goalName = goalParts[0];
                string goalDescription = goalParts[1];
                int goalPoints = int.Parse(goalParts[2]);
                AddGoal(new EternalGoal(goalName, goalDescription, goalPoints));
            } else if(goalType == "ChecklistGoal")
            {
                string[] goalParts = goalInfo.Split("||");
                string goalName = goalParts[0];
                string goalDescription = goalParts[1];
                int goalPoints = int.Parse(goalParts[2]);
                int goalBonusPoints = int.Parse(goalParts[3]);
                int goalTimes = int.Parse(goalParts[4]);
                int goalCheckComplete = int.Parse(goalParts[5]);
                AddGoal(new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonusPoints, goalTimes, goalCheckComplete));
            }
        }
    }
}