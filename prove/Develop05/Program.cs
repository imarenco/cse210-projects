using System;

class Program
{
    static void Main(string[] args)
    {

        string read = "";
        Console.Clear();

        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;

        while (read != "6")
        {
            read = Menu.GetMenuChoice();

            switch (read)
            {
                case "1":
                    {
                        string creationType = Menu.GetCreatedGoalType();
                        string name = Menu.GetGoalName();
                        string description = Menu.GetGoalDescription();
                        int points = Menu.GetGoalPoints();
                        if (creationType == "1")
                        {
                            SimpleGoal simple = new SimpleGoal(name, description, points, "simple");
                            goals.Add(simple);
                        }
                        else if (creationType == "2")
                        {
                            EternalGoal eternal = new EternalGoal(name, description, points, "eternal");
                            goals.Add(eternal);
                        }
                        else if (creationType == "3")
                        {
                            int times = Menu.GetHowManyTimes();
                            int bonus = Menu.GetBonus();
                            ChecklistGoal checklist = new ChecklistGoal(name, description, points, "checklist", bonus, times);
                            goals.Add(checklist);
                        }
                        break;
                    }
                case "2":
                    {
                        Menu.ShowListGoals(goals, false);
                        break;
                    }
                case "3":
                    FileManager.SaveToFile(goals, totalPoints);
                    break;
                case "4":
                    Tuple<List<Goal>, int> tuple = FileManager.LoadFromFile();
                    goals = tuple.Item1;
                    totalPoints = tuple.Item2;
                    break;
                case "5":
                    {
                        Menu.ShowListGoals(goals, true);
                        int position = Menu.GetAccomplish();
                        goals[position].SetCompleted();
                        Boolean isCompleted = goals[position].GetIsCompleted();
                        int points = goals[position].GetGoalPoints();
                        totalPoints = totalPoints + points;
                        Menu.ShowCongratulationText(points, totalPoints);
                        if (isCompleted && goals[position].GetType() == "checklist")
                        {
                            ChecklistGoal checklist = (ChecklistGoal)goals[position];
                            totalPoints = totalPoints + checklist.GetBonus();
                        }
                        break;
                    }
            }

            Console.WriteLine("You have " + totalPoints + " points.");
            Console.WriteLine("");
        }
    }

}