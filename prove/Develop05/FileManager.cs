using System;
using System.IO;
public class FileManager

{
    public static void SaveToFile(List<Goal> goals, int points)
    {
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {

            outputFile.WriteLine(points);
            for (int i = 0; i < goals.Count; i++)
            {

                Goal goal = goals[i];

                string line = goal.GetType() + "|" + goal.GetGoalName() + "|" + goal.GetGoalDescription() + "|" + goal.GetGoalPoints() + "|";
                if (goal.GetType() == "checklist")
                {
                    ChecklistGoal checklist = (ChecklistGoal)goals[i];

                    line = line + checklist.GetBonus() + "|" + checklist.GetTimes() + "|" + checklist.GetCompleted();
                }
                else
                {
                    line = line + goal.GetIsCompleted();
                }

                outputFile.WriteLine(line);
            }
        }
    }

    public static Tuple<List<Goal>, int> LoadFromFile()
    {
        Console.WriteLine("What it's your filename:");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        List<Goal> list = new List<Goal>();
        int totalPoints = 0;
        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i];
            if (i == 0)
            {
                totalPoints = int.Parse(lines[i]);
            }
            else
            {
                string[] parts = line.Split("|");
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                if (type == "simple")
                {
                    Boolean isCompleted = Boolean.Parse(parts[4]);
                    SimpleGoal goal = new SimpleGoal(name, description, points, type);
                    if (isCompleted)
                    {
                        goal.SetCompleted();
                    }
                    list.Add(goal);
                }
                else if (type == "eternal")
                {
                    EternalGoal goal = new EternalGoal(name, description, points, type);
                    Boolean isCompleted = Boolean.Parse(parts[4]);
                    if (isCompleted)
                    {
                        goal.SetCompleted();
                    }
                    list.Add(goal);
                }
                else if (type == "checklist")
                {
                    int bonus = int.Parse(parts[4]);
                    int times = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, type, bonus, times, completed);
                    list.Add(goal);
                }
            }
        }

        return Tuple.Create(list, totalPoints);
    }

}