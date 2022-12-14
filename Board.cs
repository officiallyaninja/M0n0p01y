namespace M0n0p01y;

public class Board
{
    private const string SPACES = "G#C#TR#c##J#U##R#C##F#c##R##u#j##C#Rc#t#";

    public static Space _getSpace(int pos)
    {
        throw new NotImplementedException();
    }
    
    private readonly Player[] _players;
    public Board(IEnumerable<Player> players)
    {
        _players = players.ToArray();
    }
    public void ShowBoard(int verticalOffset = 4, int horizontalOffset = 4)
    {
        var horizontalPadding = new string(' ', horizontalOffset);
        var internalPadding = new string(' ', 9);
        
        Console.Write(new string('\n', verticalOffset));
        Console.Write(horizontalPadding);
        for (var i = 0; i <= 10; i++)
        {
            WriteSpace(i);
        }
        Console.WriteLine();
        for (var i = 0; i < 9; i++)
        {
            Console.Write(horizontalPadding);
            WriteSpace(40-(i+1));
            Console.Write(internalPadding);
            WriteSpace(11 + i);
            Console.WriteLine();
        }
        Console.Write(horizontalPadding);
        for (var i = 30; i > 19; i--)
        {
            WriteSpace(i);
        }

    }


    public void WriteSpace(int pos)
    {
        foreach (var player in _players.OrderByDescending((x => x.IsCurrentPlayer)))
        {
            if (player.Position != pos) continue;
            
            Console.ForegroundColor = player.Color;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        //Console.Write(SPACES[pos]);
        var space = _getSpace(pos);
        if (space is Property property)
        {
            if (property is ColorProperty colorProperty)
            {
                Console.ForegroundColor = colorProperty.Color;
            }
            
            Console.BackgroundColor = property.Owner?.Color ?? ConsoleColor.Black;
        }
        Console.Write(SPACES[pos]);
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;

    }
}

