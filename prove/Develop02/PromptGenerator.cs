
public class PromptGenerator 
{
    private string[] _prompts = 
    {
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "What was the most challenging thing I faced today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I grateful for today?",
        "What did I do today that I am proud of?",
        "What did I learn today?",
        "What are some things I would like to do differently tomorrow?",
        "What did I do to help others today?",
        "What were some unexpected events that took place today?"
    };

    public string SelectPrompt() 
    {
        Random rnd = new Random();
        int index = rnd.Next(0, _prompts.Length);
        string prompt = _prompts[index];

        return prompt;
    }

}