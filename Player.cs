namespace M0n0p01y;

public class Player
{
    public ConsoleColor Color { get; }
    public int LastRoll { get; set; } = 0;
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
    public int Money  { get; set; } = 1500;
    private readonly List<Property> _ownedProperties = new List<Property>();
    public List<ColorProperty> ColorProperties => (List<ColorProperty>)_ownedProperties.Where(x => x.type == SpaceType.Property);
    public List<Utility> Utilities => (List<Utility>)_ownedProperties.Where(x => x.type == SpaceType.Utility);
    public List<RailRoad> RailRoads => (List<RailRoad>)_ownedProperties.Where(x => x.type == SpaceType.Property);
    public int JailCards { get; private set; }

    public Player(ConsoleColor color)
    {
        this.Color = color;
    }
}