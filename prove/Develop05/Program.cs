using System;

class Program
{
    public static string Indent(int count)
    {
        return "".PadLeft(count);
    }
    static void Main(string[] args)
    {
        MyGoals newGoals = new MyGoals();
        int option = 0;
        while (option != 6)
        {   
            int totalPoints = newGoals.PointsInfo;
            Console.WriteLine();
            Console.WriteLine($"You have {totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(Indent(4) + "1. Create New Goal");
            Console.WriteLine(Indent(4) + "2. List Goals");
            Console.WriteLine(Indent(4) + "3. Save Goals");
            Console.WriteLine(Indent(4) + "4. Load Goals");
            Console.WriteLine(Indent(4) + "5. Record Events");
            Console.WriteLine(Indent(4) + "6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    int choice = 0;
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine(Indent(4) + "1. Simple Goal");
                    Console.WriteLine(Indent(4) + "2. Eternal Goal");
                    Console.WriteLine(Indent(4) + "3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    choice = int.Parse(Console.ReadLine());
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, points);
                            newGoals.AddGoal(simpleGoal);
                            break;
                        case 2:
                            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, points);
                            newGoals.AddGoal(eternalGoal);
                            break;
                        case 3:
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int timeToAccomplish = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, points, timeToAccomplish, bonusPoints);
                            newGoals.AddGoal(checklistGoal);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("The goals are:");
                    newGoals.DisplayGoals(option);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("The goals are:");
                    newGoals.DisplayGoals(option);
                    Console.Write("Which goal do you want to accomplish? ");
                    int goalToComplete = int.Parse(Console.ReadLine());
                    newGoals.RecordGoal(goalToComplete);
                    break;
            }
        }
    }
}