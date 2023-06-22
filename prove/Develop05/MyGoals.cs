using System;

public class MyGoals
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public int PointsInfo
    {
        get { return _totalPoints; }
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
        AddPoints(points);
        Console.WriteLine($"You now have {_totalPoints} points!");
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
}