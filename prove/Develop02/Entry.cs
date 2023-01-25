using System;

public class Entry
{
    private string _date;
    private string _question;

    private string _response;
    public void SetDate(string date)
    {
        this._date = date;
    }


    public void SetQuestion(string question)
    {
        this._question = question;
    }


    public void SetResponse(string response)
    {
        this._response = response;
    }

    public string GetDate()
    {
        return this._date;
    }


    public string GetQuestion()
    {
        return this._question;
    }

    public string GetResponse()
    {
        return this._response;
    }




}