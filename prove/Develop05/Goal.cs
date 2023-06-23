using System;

public abstract class Goal
{
    protected string _goalName;
    protected string _goalDescription;
    protected int _points;
    protected bool _isComplete = false;

    public Goal()
    {

    }

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _points = points;
    }

    public abstract void DisplayGoal(int option);

    public abstract int RecordEvent();

    public virtual bool IsComplete(int number)
    {
        return false;
    }

    public abstract string GetStringRepresentation();
}