
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "Have you notice a tender mercy or miracle today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you learn from your family today?"
    };
    public Random _random = new Random();

    public string GetRandomPrompt()
    {
        int pickIndex = _random.Next(_prompts.Count);

        return _prompts[pickIndex];
    }

}
