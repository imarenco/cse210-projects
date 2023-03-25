
using System;

public class Video
{
    private string _id;
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments;
    public Video(string id, string title, string author, int length)
    {
        this._id = id;
        this._title = title;
        this._author = author;
        this._length = length;
    }

    public List<Comment> GetComments()
    {
        return this._comments;
    }

    public string GetTitle()
    {
        return this._title;
    }

    public void SetComments(List<Comment> comments)
    {
        this._comments = comments;
    }

    public string GetId()
    {
        return this._id;
    }

    public string GetAuthor()
    {
        return this._author;
    }

    public int GetLength()
    {
        return this._length;
    }

    public int GetAmountOfComments()
    {
        return this._comments.Count();
    }

}