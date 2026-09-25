using System.Collections.Generic; 

// This class stores one YouTube video
public class Video
{
    public string Title; 
    public string Author; 
    public int Length; 
    private List<Comment> _comments = new List<Comment>(); // List to keep all comments

    // Constructor - set title, author, length
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
    }

    // Adding  a new comment to the list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
}