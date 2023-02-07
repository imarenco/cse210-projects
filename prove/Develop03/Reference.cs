
using System;

public class Reference
{
    private string _book;
    private string _chapter;

    private string _verse;

    public Reference(string book, string chapter, string verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse + "-" + endVerse;
    }

    public string GetBook()
    {
        return this._book;
    }


    public string GetChapter()
    {
        return this._chapter;
    }

    public string GetVerse()
    {
        return this._verse;
    }
}