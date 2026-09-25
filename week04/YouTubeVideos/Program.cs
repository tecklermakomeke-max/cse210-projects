using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        // Creating a list to hold all videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# for Beginners", "Teckler", 300); 
        video1.AddComment(new Comment("Joseph", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Martha", "I learned a lot."));
        video1.AddComment(new Comment("Pinel", "Please make part 2."));
        videos.Add(video1); 

        Video video2 = new Video("How to Use Classes", "BYU Teacher", 450);
        video2.AddComment(new Comment("Nozi", "Now I understand abstraction."));
        video2.AddComment(new Comment("Jey", "Simple explanation."));
        video2.AddComment(new Comment("Dean", "Good example."));
        videos.Add(video2);

        Video video3 = new Video("Chamber of Commerce Project", "Teckler N Makomeke", 600);
        video3.AddComment(new Comment("Jan", "Great website!"));
        video3.AddComment(new Comment("Silindiwe", "I like the design."));
        video3.AddComment(new Comment("Donny", "How did you do the grid?"));
        videos.Add(video3);

        // --- Show all videos ---
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}"); 
            Console.WriteLine($"Author: {video.Author}"); 
            Console.WriteLine($"Length: {video.Length} seconds"); 
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}"); 

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.Name} - {comment.Text}");
            }
            Console.WriteLine(); 
        }
    }
}