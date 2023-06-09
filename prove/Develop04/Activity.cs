using System;

public class Activity
{
    protected string _actName;
    protected string _actDescription;
    protected int _actDuration;
    private static Random _rnd = new Random();

    public void DisplayStartMsg()
    {   
        Console.WriteLine($"Welcome to the {_actName}\n");
        Console.WriteLine($"{_actDescription}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int secondsToAdd = int.Parse(Console.ReadLine());
        _actDuration = secondsToAdd;

        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(3);
    }

    public void DisplayEndMsg()
    {   
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_actDuration} seconds of the {_actName}");
        DisplaySpinner(3);
    }

    protected void DisplaySpinner(int time)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animation)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        } 
    }

    protected void DisplayCountdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected string SelectRandomPrompt(string[] prompts)
    {   
        int index = _rnd.Next(0, prompts.Length);      
        return prompts[index];
    }
}