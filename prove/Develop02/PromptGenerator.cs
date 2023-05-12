
public class PromptGenerator 
{
    private string[] _prompts = 
    {
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?"
    };

    public string SelectPrompt() 
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Length);
        string prompt = _prompts[index];

        return prompt;
    }

}