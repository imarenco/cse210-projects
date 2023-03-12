
using System;

public class ChecklistGoal : Goal
{
    int _bonus;

    int _times;

    int _completed;
    public ChecklistGoal(string name, string description, int points, string type, int bonus, int times) : base(name, description, points, type)
    {
        this._bonus = bonus;
        this._times = times;
        this._completed = 0;
    }


    public ChecklistGoal(string name, string description, int points, string type, int bonus, int times, int completed) : base(name, description, points, type)
    {
        this._bonus = bonus;
        this._times = times;
        this._completed = completed;
    }


public int GetCompleted() {
    return this._completed;
}

    public override Boolean GetIsCompleted()
    {

        return this._times == this._completed;

    }

    public override void ShowGoal()
    {
        string isChecked = GetIsCompleted() ? "X" : " ";
        Console.WriteLine("[" + isChecked + "]" + this._name + "(" + this._description + ") --Currently completed: " + this._completed + "/" + this._times);
    }

    public int GetBonus()
    {
        return this._bonus;
    }


    public int GetTimes()
    {
        return this._times;
    }

    public override void SetCompleted()
    {
        if (this._completed < this._times)
        {
            this._completed = this._completed + 1;
        }
    }
}