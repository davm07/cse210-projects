using System;

public class ReflectionActivity : Activity
{
    private string[] _refQuestions = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private string[] _fixedQuestions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectionActivity()
    {
        _actName = "Reflection Activity";
        _actDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    private void DisplayRandomPrompt()
    {
        Console.WriteLine($"\n--- {SelectRandomPrompt(_refQuestions)} ---\n");
    }

    private void DisplayFixedPrompt()
    {
        Console.Write($"> {SelectRandomPrompt(_fixedQuestions)} ");
    }

    public void RenderActivity()
    {
        Console.WriteLine("\nConsider the following prompt:");
        DisplayRandomPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        DisplayCountdown(3);
        Console.Clear();

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_actDuration);

        while (DateTime.Now < endTime)
        {   
            DisplayFixedPrompt();
            DisplaySpinner(8);
            Console.WriteLine();
        }
    }
}