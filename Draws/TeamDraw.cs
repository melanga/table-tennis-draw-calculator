namespace TableTennisDrawCalculator.Draws;

public class TeamDraw : IDraw
{
    private List<string?> _members = new List<string?>();
    private List<string[]?> _listOfMatches = new List<string[]?>();

    public void Input()
    {
        Console.WriteLine("Input total no of members: ");
        var totalMembers = Console.ReadLine();
        try
        {
            var count = Convert.ToByte(totalMembers);
            
            for (var i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter Player {count}");
                _members.Add(Console.ReadLine());
            }
            Console.WriteLine($"Team's Players ::");
            foreach (var member in _members)
            {
                Console.WriteLine(member);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error Occured");
        }
        
    }

    public void Calculate()
    {
        Console.WriteLine("Calculating match list...");
        GenerateTotalMatches(_members.Count);
        Console.WriteLine($"Total No of matches: {_listOfMatches.Count}");
        foreach (var match in _listOfMatches)
        {
            Console.WriteLine($"{match[0]} vs {match[1]}");
        }
    }

    private void GenerateTotalMatches(int number)
    {
        var n = number;
        while (n>1)
        {
            _listOfMatches.Add(new string[]{ _members[number-1], _members[n-2]});
            n--;
        }
        if (number == 1)
        {
            return;
        }
        GenerateTotalMatches(number - 1);
    }
}