public class PromptGenerator
{
    List<string> _prompts = new List<string>{
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What am I grateful for today?",
    "Who made me smile today?"
    };
    public string GetRandom()
    {
        return _prompts[new Random().Next(_prompts.Count)];
    }
}