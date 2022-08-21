namespace M0n0p01y;

public record ColorProperty : Property
{
    public static readonly List<ColorProperty> ALL = new List<ColorProperty>();
    public int Id => ALL.IndexOf(this);
    public int _houses { get; set; } = 0;
    private readonly int[] _rent;
    public readonly ConsoleColor _color;
    public int[] Rent => _rent.ShallowCopy();

    public bool IsInMonopoly =>
        Equals(Owner?.ColorProperties.Where(x => x._color == _color), ALL.Where(x => x._color == _color));
    public ColorProperty(string name, int position, int mortgageValue, int cost, int[] rent, ConsoleColor color) : base(name, SpaceType.Property, position,  mortgageValue, cost)
    {
        if (rent.Length != 6) throw new ArgumentException("rent must be a 6 element array");
        _rent = rent;
        _color = color;
    }

    public override int CalculateRent()
    {
        _ = Owner ?? throw new InvalidOperationException("Owner is null");
        if (IsInMonopoly && _houses == 0) return _rent[0] * 2;
        return _rent[_houses];
    }
}

