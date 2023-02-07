
using System;

public class Scripture
{
    private Reference _reference;


    // amount of hide words per enter
    private int _amount;
    private List<Word> _text;

    public Scripture(Reference reference, string text)
    {

        this._amount = 3;
        this._reference = reference;
        this._text = new List<Word>();

        string[] texts = text.Split(" ");
        for (int i = 0; i < texts.Length; i++)
        {
            this._text.Add(new Word(texts[i]));
        }
    }

    public void HideWords()
    {
        Random random = new Random();
        List<int> positionList = new List<int>();

        for (int i = 0; i < this._text.Count; i++)
        {
            if (!this._text[i].IsHidden())
            {
                positionList.Add(i);
            }
        }


        for (int x = 0; x < this._amount; x++)
        {
            int z = random.Next(positionList.Count);
            
            this._text[positionList[z]].Hide();
        }
    }


    public string GetReferenceInformation()
    {
        string book = this._reference.GetBook();
        string chapter = this._reference.GetChapter();
        string verse = this._reference.GetVerse();

        return book + " " +  chapter + ":" + verse;
    }

    public string GetRendererText()
    {

        string text = "";

        for (int i = 0; i < this._text.Count; i++)
        {
            text += this._text[i].getRendererText() + " ";
        }


        return text;
    }


    public bool IsAllHidden()
    {
        bool isAllHidden = true;

        for (int i = 0; i < this._text.Count; i++)
        {
            if (!this._text[i].IsHidden())
            {
                isAllHidden = false;
                break;
            }
        }

        return isAllHidden;

    }
}