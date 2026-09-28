using System;

public class Comment
{
    private string _commenterName;
    private string _comment;

    public Comment(string commenterName, string comment)
    {
        _commenterName = commenterName;
        _comment = comment;
    }

    public void displayComment()
    {
        Console.WriteLine($"{_commenterName}: {_comment}");
    }
}
