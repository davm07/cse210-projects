using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        base.ActNameInfo = "Breathing Activity";
        base.ActDescriptionInfo = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RenderActivity()
    {   
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner();

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(base.ActDurationInfo);

        while (DateTime.Now < endTime)
        {   
            Console.Write("\nBreathe in...");
            DisplayCountdown(4);
            Console.Write("\nNow Breathe out...");
            DisplayCountdown(5);
            Console.WriteLine();
        }

        DisplayEndMsg();
    }

}