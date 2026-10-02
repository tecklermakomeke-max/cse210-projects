public class Activity
{
    protected string _name;
    protected string _desc;
    protected int _time;

    public Activity(string name, string desc)
    {
        _name = name;
        _desc = desc;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_desc);
        Console.Write("How long in seconds? ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Spinner(3);
    }

    public void End()
    {
        Console.WriteLine("Well done!");
        Spinner(2);
        Console.WriteLine($"You did {_name} for {_time} seconds.");
        Spinner(3);
    }

    public void Spinner(int sec)
    {
        for (int i = 0; i < sec * 2; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void Countdown(int sec)
    {
        for (int i = sec; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b");
        }
        Console.WriteLine();
    }
}