public class GoalTest
{
    protected List<GoalTest> _goals = new List<GoalTest>();
    protected string _goalName;
    protected string _goalDescription;

    public GoalTest(string name, string description)
    {
        _goalName = name;
        _goalDescription = description;
    }
    public void DisplayGoal() 
    {
        Console.WriteLine($"My goal is: {_goalName} ({_goalDescription})");
    }

    public void AddGoal(GoalTest goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        foreach (var goal in _goals)
        {
            DisplayGoal();
        }
    }
}