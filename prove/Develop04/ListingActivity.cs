using System;

public class ListingActivity : Activity
{
    private string[] _prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity()
    {
        _actName = "Listing Activity";
        _actDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"--- {SelectRandomPrompt(_prompts)} ---");
    }

    public void RenderActivity()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        DisplayCountdown(3);
        Console.WriteLine();

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_actDuration);

        int counter = 0;
        while (DateTime.Now < endTime)
        {   
            Console.Write("> ");
            string items = Console.ReadLine() + "\n";  
            counter++;    
        }
        Console.WriteLine($"You listed {counter} items!");
    }
}