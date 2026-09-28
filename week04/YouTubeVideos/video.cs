using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private int _length;
    private string _author;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public string getVideoTitle()
    {
        return _title;
    }

    public int numberOfComment()
    {
        return _comments.Count;
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void displayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {numberOfComment()}");
        Console.WriteLine();

        foreach (Comment comment in _comments)
        {
            comment.displayComment();
        }
    }
}
