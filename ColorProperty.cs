namespace M0n0p01y;

public record ColorProperty : Property
{
    public int _houses { get; set; } = 0;
    private readonly int[] _rent;
    private readonly ConsoleColor _color;
    public int[] Rent => _rent.ShallowCopy();
    public ColorProperty(string name, int position, int mortgageValue, int cost, int[] rent, ConsoleColor color) : base(name, SpaceType.Property, position,  mortgageValue, cost)
    {
        if (rent.Length != 6) throw new ArgumentException("rent must be a 6 element array");
        _rent = rent;
        _color = color;
    }

    public override int CalculateRent()
    {
        return _rent[_houses];
    }
}

