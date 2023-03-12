class TerminalManager
{
    public static string GetMenuChoice()
    {

        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu:");

        string read = Console.ReadLine();
        return read;
    }


    public static string GetCreatedGoalType()
    {

        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.WriteLine("Wich type of goal would you like to create?");

        string read = Console.ReadLine();
        return read;
    }

    public static string GetGoalName()
    {

        Console.WriteLine("What is the name of your goal?");

        string read = Console.ReadLine();
        return read;
    }



    public static string GetGoalDescription()
    {

        Console.WriteLine("What is a short description of it?");

        string read = Console.ReadLine();
        return read;
    }


    public static int GetGoalPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goals?");

        return int.Parse(Console.ReadLine());
    }


    public static void ShowListGoals(List<Goal> goals, Boolean onlyTitle)
    {
        Console.WriteLine("The goals are:");

        for (int x = 0; x < goals.Count; x++)
        {
            if (onlyTitle)
            {
                Console.WriteLine((x + 1) + ". " + goals[x].GetGoalName());
            }
            else
            {
                goals[x].ShowGoal();
            }
        }

        Console.WriteLine("");

    }

    public static int GetHowManyTimes()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        return int.Parse(Console.ReadLine());
    }


    public static int GetBonus()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        return int.Parse(Console.ReadLine());
    }

    public static int GetAccomplish()
    {
        Console.WriteLine("Wich goal did you want to accomplish?");
        return int.Parse(Console.ReadLine()) - 1;
    }

    public static void ShowCongratulationText(int earned, int total)
    {
        Console.WriteLine("Congratulations! You have earned " + earned + " points!");
        Console.WriteLine("You now have " + total + " points!");
    }

}