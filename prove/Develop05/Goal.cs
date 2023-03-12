public class Goal
{
    protected string _name;
    protected int _points;
    protected string _description;
    private string _type;
    private Boolean _isCompleted;
    public Goal(string name, string description, int points, string type)
    {
        this._name = name;
        this._description = description;
        this._points = points;
        this._type = type;
        this._isCompleted = false;
    }


    public int GetGoalPoints()
    {
        return this._points;
    }

    public string GetGoalDescription()
    {
        return this._description;
    }



    public string GetType()
    {
        return this._type;
    }

    public string GetGoalName()
    {
        return this._name;
    }

    public virtual void ShowGoal()
    {
        string isChecked = GetIsCompleted() ? "X" : " ";
        Console.WriteLine("[" + isChecked + "]" + this._name + "(" + this._description + ")");
    }

    public virtual Boolean GetIsCompleted()
    {
        return this._isCompleted;
    }

    public virtual void SetCompleted()
    {
        this._isCompleted = true;
    }
}
