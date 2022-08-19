namespace M0n0p01y;

public class Player
{
    public ConsoleColor color { get; }

    private int _position;
    public int Position
    {
        get
        {
            return _position;
        }

        set
        {
            _position = value % 40;
        }
    }
    public bool IsCurrentPlayer { get; set; } = false;
    public int Money  { get; private set; } = 1500;
    public List<Property> Properties { get; private set; } = new List<Property>();
    public List<Utility> Utilities { get; private set; } = new List<Utility>();
    public int JailCards { get; private set; }

    public Player(ConsoleColor color)
    {
        this.color = color;
    }
}