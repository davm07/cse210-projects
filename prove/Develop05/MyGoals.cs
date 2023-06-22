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
}