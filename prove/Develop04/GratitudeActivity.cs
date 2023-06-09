using System;

public class GratitudeActivity : Activity
{   
    private string[] _gratitudePrompts = {"I'm grateful for three things I hear:", "I'm grateful for three things I see:", "I'm grateful for three things I smell:", "I'm grateful for these three things I taste:", "I'm grateful for these three friends:", "I'm grateful for these three things in my home:", "I'm grateful for these three things I've learned:", "I'm grateful for three acts of kindness I have received:", "I'm grateful for these three opportunities I have been given:"};
    public GratitudeActivity()
    {
        _actName = "Gratitude Activity";
        _actDescription = "This activity will help you think about the things in your life for which you are grateful, followed by writing down what you think.";
    }

    private void DisplayPrompt()
    {
        Console.WriteLine($"\n{SelectRandomPrompt(_gratitudePrompts)}");
    }
    
    public void RenderActivity()
    {
        Console.WriteLine("\nYou will have prompts to help you think the thing you are grateful for.");
        Console.Write("You may begin in: ");
        DisplayCountdown(3);
        Console.WriteLine();
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_actDuration);

        while(DateTime.Now < endTime)
        {   
            int count = 0;
            DisplayPrompt();
            do
            {   
                Console.Write($"{count + 1}. ");
                Console.ReadLine();
                count++;
            } while (count < 3);
        }
    }
}