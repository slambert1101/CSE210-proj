using System;
using System.Reflection;
using System.Transactions;

class Video
{
    private int _length;
    private string _title;
    private string _author;

    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        comments = [];
    }


    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_title}, by {_author}. ({_length} seconds)");
        Console.WriteLine($"    {CommentCount()} comments:");
        foreach(Comment comment in comments)
        {
            Console.WriteLine($"    {comment.GetName()}: {comment.GetText()}");
        }
    }

    public int CommentCount()
    {
        return comments.Count();
    }

}