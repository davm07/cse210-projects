using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void DisplayGoal(int option)
    {
        switch (option)
        {
            case 2:
                Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
                break;
            case 5:
                Console.WriteLine(_goalName);
                break;
        }
    } 
        
    public override int RecordEvent()
    {
        int earnedPoints = _points;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return earnedPoints;
    }

    // public override bool IsComplete(int number)
    // {
    //     return false;
    // }

    public override string GetStringRepresentation()
    {
        string goalString = $"EternalGoal**{_goalName}||{_goalDescription}||{_points}";
        return goalString;
    }
}