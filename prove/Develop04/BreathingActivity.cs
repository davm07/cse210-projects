using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _actName = "Breathing Activity";
        _actDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RenderActivity()
    {   
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_actDuration);

        while (DateTime.Now < endTime)
        {   
            Console.Write("\nBreathe in...");
            DisplayCountdown(4);
            Console.Write("\nNow Breathe out...");
            DisplayCountdown(6);
            Console.WriteLine();
        }
    }

}