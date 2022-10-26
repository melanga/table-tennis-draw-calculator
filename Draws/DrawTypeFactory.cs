namespace TableTennisDrawCalculator.Draws;

public class DrawTypeFactory
{
    private string _type;

    public DrawTypeFactory(string type)
    {
        this._type = type;
    }

    public IDraw? GetDraw()
    {
        switch (_type)
        {
            case "1":
                return new TeamDraw();
            default:
                return null;
        }
    }
}