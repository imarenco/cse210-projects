using System;

public class Entry
{
    private string _date;
    private string _question;

    private string _response;
    public void setDate(string date)
    {
        this._date = date;
    }


    public void setQuestion(string question)
    {
        this._question = question;
    }


    public void setResponse(string response) {
        this._response = response;
    }

    public string getDate()
    {
        return this._date;
    }


    public string getQuestion()
    {
        return this._question;
    }

    public string getResponse()
    {
        return this._response;
    }




}