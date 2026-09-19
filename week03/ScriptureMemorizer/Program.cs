using System;

class Program
{
    static void Main(string[] args)
    {
        // Create reference - Proverbs 3:5-6 (multi verse)
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);

        // The scripture text to memorize
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths";

        Scripture scripture = new Scripture(ref1, text);

        while (true)
        {
            Console.Clear(); 
            Console.WriteLine(scripture.GetDisplay());
            Console.WriteLine();

            // If all hidden, finish
            if (scripture.IsAllHidden())
            {
                Console.WriteLine("All words hidden - well done!");
                break;
            }

            // Asking the user
            Console.WriteLine("Press ENTER to hide more words or type 'quit' to stop.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // Hide 3 words each time
            scripture.HideRandomWords(3);
        }
    }
}
