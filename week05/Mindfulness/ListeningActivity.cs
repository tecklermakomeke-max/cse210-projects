public class ListingActivity : Activity
{
    List<string> prompts = new List<string> {
        "Who do you appreciate?",
        "What are your strengths?",
        "Who have you helped this week?"
    };

    public ListingActivity() : base("Listing", "List good things in your life.") { }

    public void Run()
    {
        Start();
        Random r = new Random();
        Console.WriteLine(prompts[r.Next(prompts.Count)]);
        Console.Write("You have: ");
        Countdown(5);

        int count = 0;
        DateTime end = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
        End();
    }
}