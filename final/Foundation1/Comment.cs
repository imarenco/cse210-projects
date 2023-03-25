
public class Comment
{
    private string _video;
    private string _name;
    private string _text;
    public Comment(string video, string name, string text)
    {
        this._video = video;
        this._name = name;
        this._text = text;
    }

    public string GetVideo()
    {
        return this._video;
    }


    public string GetName()
    {
        return this._name;
    }

    public string GetText()
    {
        return this._text;
    }
}