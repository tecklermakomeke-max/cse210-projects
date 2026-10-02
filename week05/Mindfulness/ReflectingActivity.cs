public class ReflectingActivity : Activity
{
    List<string> prompts = new List<string> {
        "Think of a time you helped someone.",
        "Think of a time you did something hard."
    };
    List<string> questions = new List<string> {
        "Why was it meaningful?",
        "How did you feel after?",
        "What did you learn?",
        "How can you use this again?"
    };

    public ReflectingActivity() : base("Reflecting", "Reflect on your strength.") { }

    public void Run()
    {
        Start();
        Random r = new Random();
        Console.WriteLine(prompts[r.Next(prompts.Count)]);
        Console.WriteLine("Press enter when ready.");
        Console.ReadLine();

        DateTime end = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < end)
        {
            Console.WriteLine(questions[r.Next(questions.Count)]);
            Spinner(5);
        }
        End();
    }
}