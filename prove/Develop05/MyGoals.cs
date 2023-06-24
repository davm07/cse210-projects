using System;

public class MyGoals
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;
    private int _level = 1;

    public int PointsInfo
    {
        get { return _totalPoints; }
    }
    public int LevelInfo
    {
        get { return _level; }
    }
    

    public void CreateGoals(int choice)
    {   
        if (choice <= 0 || choice > 3)
        {
            Console.WriteLine("Please choose a valid type of goal!");
        } 
        else
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
            } 
            else if(choice == 2)
            {
                AddGoal(new EternalGoal(goalName, goalDescription, points));
            } 
            else if(choice == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int timeToAccomplish = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                AddGoal(new ChecklistGoal(goalName, goalDescription, points, timeToAccomplish, bonusPoints));
            }
        }
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals(int option)
    {   
        if(_goals.Count > 0)
        {
            int count = 1;
            foreach (var goal in _goals)
            {   
                Console.Write($"{count}. ");
                goal.DisplayGoal(option);
                count++;
            }
        }
        else
        {
            Console.WriteLine("You don't have any goal at this time!");
        }
    }

    public void RecordGoal(int option)
    {   
        if (option > 0 && option <= _goals.Count)
        {
            int points = _goals[option -1].RecordEvent();
            _totalPoints += points;
            LevelUp(_totalPoints);
            Console.WriteLine($"You now have {_totalPoints} points!");
        }
        else
        {
            Console.WriteLine("Please type a valid option!");
        }
        
    }

    public void LevelUp(int number)
    {
        if (number >= 200 && number < 500)
        {
            _level = 2;
        }
        else if (number >= 500 && number < 800)  
        {
            _level = 3;
        }
        else if (number >= 800 && number < 1200)
        {
            _level = 4;
        }
        else if(number >= 1200)
        {
            _level = 5;
        }
    }

    public void SaveGoals(string filename)
    {   
        if(_goals.Count > 0)
        {
            using(StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_totalPoints);
                outputFile.WriteLine(_level);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
        else
        {
            Console.WriteLine("There are not goals to save at this time");
        }
    }

    public void LoadGoals(string filename)
    {   
        if (File.Exists(filename))
        {   
            string [] arrayLines = File.ReadAllLines(filename);
            if(arrayLines.Length > 0)
            {
                string value = File.ReadLines(filename).Take(1).First();
                int points = int.Parse(value);
                _totalPoints += points;
                string value2 = File.ReadLines(filename).Skip(1).Take(1).First();
                int level = int.Parse(value2);
                _level = level;
                string [] lines = File.ReadAllLines(filename).Skip(2).ToArray(); 
                foreach (var line in lines)
                {
                    string[] parts = line.Split("**");
                    string goalType = parts[0];
                    string goalInfo = parts[1];
                    if(goalType == "SimpleGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        int goalPoints = int.Parse(goalParts[2]);
                        bool goalComplete = bool.Parse(goalParts[3]);
                        AddGoal(new SimpleGoal(goalName, goalDescription, goalPoints, goalComplete));
                    } 
                    else if (goalType == "EternalGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        int goalPoints = int.Parse(goalParts[2]);
                        AddGoal(new EternalGoal(goalName, goalDescription, goalPoints));
                    } 
                    else if(goalType == "ChecklistGoal")
                    {
                        string[] goalParts = goalInfo.Split("|");
                        string goalName = goalParts[0];
                        string goalDescription = goalParts[1];
                        int goalPoints = int.Parse(goalParts[2]);
                        int goalBonusPoints = int.Parse(goalParts[3]);
                        int goalTimes = int.Parse(goalParts[4]);
                        int goalCheckComplete = int.Parse(goalParts[5]);
                        bool goalIsComplete = bool.Parse(goalParts[6]);
                        AddGoal(new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonusPoints, goalTimes, goalCheckComplete, goalIsComplete));
                    }
                }
            }
            else
            {
                Console.WriteLine($"The file {filename} doesn't have any information!");
            }
        }
        else
        {
            Console.WriteLine($"The file {filename} doesn't exist, please try another name!");
        }  
    }     
}