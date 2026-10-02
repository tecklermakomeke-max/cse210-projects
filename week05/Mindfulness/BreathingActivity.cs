public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "Relax by breathing slowly.") { }

    public void Run()
    {
        Start();
        DateTime end = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            Countdown(3);
            Console.Write("Breathe out... ");
            Countdown(3);
        }
        End();
    }
}