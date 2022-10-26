using TableTennisDrawCalculator.Draws;

namespace TableTennisDrawCalculator;

public class AppView
{
    // no thread safe singleton pattern
    private AppView()
    {
    }

    private static AppView _instance = new AppView();

    public static AppView GetInstance()
    {
        return _instance;
    }

    public void GreetUser()
    {
        Console.WriteLine("<------ Table Tennis Draw Calculator ------>");
        Console.WriteLine("Calculate Draws of Table Tennis Matches");
    }

    public void GetDrawTypeView()
    {
        Console.WriteLine("\nWhat is the Draw Type you want?");
        Console.WriteLine("Please input the corresponding number...");
        foreach (int i in Enum.GetValues(typeof(DrawType)))
        {
            Console.WriteLine( "" + i + ": "+ (DrawType)i);
        }
    }
}