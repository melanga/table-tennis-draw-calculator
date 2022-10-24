using TableTennisDrawCalculator.Draws;

namespace TableTennisDrawCalculator;

public class Program
{
    public static void Main(string[] args)
    {
        var appView = AppView.GetInstance();
        appView.GreetUser();
        appView.GetDrawTypeView();
        
        var drawType = Console.ReadLine();
        Console.WriteLine($"Selected option: {drawType}");
        if (drawType == null) return;
        var draw = new DrawTypeFactory(drawType).GetDraw();
        if (draw == null)
        {
            Console.WriteLine("Entered a wrong input");
        }
        else
        {
            draw.Input();
            draw.Calculate();
        }
    }
}