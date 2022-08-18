namespace M0n0p01y;

public class Board
{
    private const string SPACES = "G#C#TR#c##J#U##R#C##F#c##R##u#j##C#Rc#t#";
    private readonly Player[] _players;
    public Board(Player[] players)
    {
        _players = players;
    }
    public void ShowBoard(int verticalOffset, int horizontalOffset)
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
    public Space this[int pos]
    {
        get
        {
            throw new NotImplementedException();
        }
    }
    public void WriteSpace(int pos)
    {
        foreach (var player in _players)
        {
            if (player.Position != pos) continue;
            
            Console.ForegroundColor = player.color;
            Console.Write("@");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        Console.Write(SPACES[pos]);

        
    }
}
