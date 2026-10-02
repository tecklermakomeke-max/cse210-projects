class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Breathing\n2. Reflecting\n3. Listing\n4. Quit");
            Console.Write("Choose: ");
            string c = Console.ReadLine();

            if (c == "1") { new BreathingActivity().Run(); }
            else if (c == "2") { new ReflectingActivity().Run(); }
            else if (c == "3") { new ListingActivity().Run(); }
            else if (c == "4") break;
        }
    }
}