namespace M0n0p01y;

public record Property : Buyable
{
    public int _houses { get; set; } = 0;
    private readonly int[] _rent;
    public int[] Rent => _rent.ShallowCopy();
    public Property(string name, SpaceType type, int position, int mortgageValue, int cost, int[] rent) : base(name, SpaceType.Property, position,  mortgageValue, cost)
    {
        if (rent.Length != 6) throw new ArgumentException("rent must be a 6 element array");
        _rent = rent;
    }

    public override int CalculateRent()
    {
        return _rent[_houses];
    }
}
