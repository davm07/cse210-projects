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
                    newGoals.CreateGoals(choice);
                    break;
                case 2:
                    Console.WriteLine("The goals are:");
                    newGoals.DisplayGoals(option);
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    newGoals.SaveGoals(filename);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string filenameLoad = Console.ReadLine();
                    newGoals.LoadGoals(filenameLoad);
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