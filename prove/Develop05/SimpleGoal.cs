using System;

public class SimpleGoal : Goal
{   
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void DisplayGoal(int option)
    {
        switch (option)
        {
            case 2:
                if (!_isComplete)
                {
                    Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
                } else {
                    Console.WriteLine($"[X] {_goalName} ({_goalDescription})");
                }
                
                break;
            case 5:
                Console.WriteLine(_goalName);
                break;
        } 
    }

    public override int RecordEvent()
    {   int earnedPoints = 0;
        if(!_isComplete)
        {
            earnedPoints = _points;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            _isComplete = IsComplete(earnedPoints);
            
        } else 
        {
            Console.WriteLine("You already complete this goal!");
        }
        return earnedPoints;
        
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete(int number)
    {
        bool completed = false;
        if(number == _points)
        {
            completed = true;
            return completed;
        } else {
            return completed;
        }
    }
}