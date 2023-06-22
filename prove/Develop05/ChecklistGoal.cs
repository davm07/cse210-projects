using System;

public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _bonusPoints;
    private int _checkComplete;

    public ChecklistGoal(string name, string description, int points, int times, int bonusPoints) : base(name, description, points)
    {
        _timesToComplete = times;
        _bonusPoints = bonusPoints;
    }

    public ChecklistGoal(string name, string description, int points, int bonusPoints, int times, int checkComplete) : base(name, description, points)
    {
        _timesToComplete = times;
        _bonusPoints = bonusPoints;
        _checkComplete = checkComplete;
    }

    public override void DisplayGoal(int option)
    {
        switch (option)
        {
            case 2:
                if(_isComplete)
                {
                    Console.WriteLine($"[X] {_goalName} ({_goalDescription}) -- Currently Completed: {_checkComplete}/{_timesToComplete}");
                } else 
                {
                    Console.WriteLine($"[ ] {_goalName} ({_goalDescription}) -- Currently Completed: {_checkComplete}/{_timesToComplete}");
                }
                break;
            case 5:
                Console.WriteLine(_goalName);
                break;
        }
    }

    public override int RecordEvent()
    {   
        int earnedPoints = 0;
        if(!_isComplete)
        {   
            _checkComplete++;
            earnedPoints = _points;
            _isComplete = IsComplete(_checkComplete);
            if(_checkComplete == _timesToComplete) 
            {
                earnedPoints = _points + _bonusPoints;
                Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
            } else 
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
            }
            
        } else {
            Console.WriteLine("You already complete this goal!");
        }
        return earnedPoints;
    }

    public override bool IsComplete(int number)
    {
        bool completed = false;
        if(number == _timesToComplete)
        {
            completed = true;
            return completed;
        } else {
            return completed;
        }
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"ChecklistGoal**{_goalName}||{_goalDescription}||{_points}||{_bonusPoints}||{_timesToComplete}||{_checkComplete}";
        return goalString;
    }
}