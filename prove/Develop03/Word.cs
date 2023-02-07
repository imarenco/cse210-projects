
using System;

public class Word
{
    private bool _hide;
    private string _word;

    public Word(string word)
    {
        this._word = word;
        this._hide = false;
    }

    public void Hide()
    {
        this._hide = true;
    }

    public bool IsHidden()
    {

        return this._hide;
    }

    public string getRendererText()
    {
        return this._hide ? new String('_', _word.Length) : this._word;
    }
}