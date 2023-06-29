class Program
{
    static void Main(string[] args)
    {   
    //     GoalTest mainGoal = new GoalTest("x", "!");
    //     SimpleGoaltest simpGoal = new SimpleGoaltest("Run a mile", "Run a mile in the morning");
    //     simpGoal.AddGoal(simpGoal);

    //     SimpleGoaltest goal2 = new SimpleGoaltest("Call my mom", "I will call my mom in the afternoon");
    //     goal2.AddGoal(goal2);

    //     mainGoal.DisplayGoals();

    //     static void LoadGoals(string filename)
    //     {
    //         string value = File.ReadLines(filename).Take(1).First();
    //         Console.WriteLine(value);

    //         string[] lines = File.ReadAllLines(filename).Skip(1).ToArray();
            
    //         foreach (var line in lines)
    //         {   
    //             string[] parts = line.Split(":");
    //             string code = parts[0];
    //             string rest = parts[1];
    //             string[] restHalf = rest.Split("**");
    //             string ms1 = restHalf[0];
    //             string ms2 = restHalf[1];
    //             if (parts[0] == "J26")
    //             {
    //                 Console.WriteLine($"{ms1} - {ms2}");
    //             } else if(parts[0] == "X29")
    //             {
    //                 Console.WriteLine($"{ms1} - {ms2}");
    //             } else if(parts[0] == "C28")
    //             {
    //                 Console.WriteLine($"{ms1} - {ms2}");
    //             }
    //         }
    //     }

    //     LoadGoals("test.txt");
        Activity activity = new Activity("hey", 13);
        Console.WriteLine(activity.Distance());
    }
}