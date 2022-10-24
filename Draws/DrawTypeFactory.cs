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
            case "team-selection":
                return new TeamDraw();
            default:
                return null;
        }
    }
}