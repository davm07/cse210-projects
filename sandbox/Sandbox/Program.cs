class Program
{
    static void Main(string[] args)
    {   
        GoalTest mainGoal = new GoalTest("x", "!");
        SimpleGoaltest simpGoal = new SimpleGoaltest("Run a mile", "Run a mile in the morning");
        simpGoal.AddGoal(simpGoal);

        SimpleGoaltest goal2 = new SimpleGoaltest("Call my mom", "I will call my mom in the afternoon");
        goal2.AddGoal(goal2);

        mainGoal.DisplayGoals();

    }
}