namespace TableTennisDrawCalculator;

public class AppView
{
    // no thread safe singleton pattern
    private AppView()
    {
    }

    private static AppView _instance;

    public static AppView GetInstance()
    {
        if (_instance == null)
        {
            _instance = new AppView();
        }
        return _instance;
    }

    public void GreetUser()
    {
        Console.WriteLine("Table Tennis Draw Calculator");
    }

    public void GetDrawTypeView()
    {
        Console.WriteLine("what is draw type?");
    }
}