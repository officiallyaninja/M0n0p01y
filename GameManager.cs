namespace M0n0p01y;

public class GameManager
{

    private static readonly Random RNG = new Random();

    private readonly Player[] _players;
    public GameManager(IEnumerable<Player> players)
    {
        _players = players.ToArray();
    }
    
    private int _currentPlayerIndex = 0;
    public int DoublesRolled;
    public Player CurrentPlayer
    {
        get
        {
            return _players[_currentPlayerIndex];
        }
    }

    public int RollDiceAndMove()
    {
        var roll1 = RNG.Next() % 6 + 1;
        var roll2 = RNG.Next() % 6 + 1;
        var isDouble = roll1 == roll2;
        var sum = roll1 + roll2;
        
        CurrentPlayer.LastRoll = sum;
        
        if (isDouble)
        {
            DoublesRolled += 1;
            Console.WriteLine();
            Console.WriteLine("DOUBLES");
            Console.WriteLine($"{roll1}, {roll2}");
        }
        
        if (DoublesRolled == 3)
        {
            _goToJail();
            _endTurn();
            return sum;
        }
        
        _movePlayerBy(sum);
        if (!isDouble)
        {
            _endTurn();
        }
        return sum;

    }
    private void _goToJail()
    {
        CurrentPlayer.Position = 10;
    }
    private void _endTurn()
    {
        DoublesRolled = 0;
        _currentPlayerIndex = (_currentPlayerIndex + 1) % _players.Length;
        foreach (var player in _players)
        {
            player.IsCurrentPlayer = player == CurrentPlayer;
        }
    }

    private void _movePlayerBy(int spaces, bool isPlayerActive = true)
    {
        CurrentPlayer.Position += spaces;
        if (isPlayerActive)
        {
            _activateSpace();
        }
    }
    private void _activateSpace()
    {
        //var space = Board.getSpace(CurrentPlayer.Position);
        //TODO: Switch case here
    }
}


