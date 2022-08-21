namespace M0n0p01y;

public record RailRoad : Property
{
    public static readonly List<RailRoad> ALL = new List<RailRoad>();

    public int Id => ALL.IndexOf(this);
    public RailRoad(string name, int position) : base(name, SpaceType.RailRoad, position, 100, 200)
    {
        ALL.Add(this);
    }
    public override int CalculateRent()
    {
        _ = Owner ?? throw new InvalidOperationException("Owner is null");
        return Owner.RailRoads.Count switch
        {
            1 => 25,
            2 => 50,
            3 => 100,
            4 => 200,
            _ => throw new InvalidOperationException(
                "how the fuck does this player have more than 4 or less than 1 Railroads????")
        };
    }
    public void Deconstruct(out string name, out int position)
    {
        name = this.name;
        position = this.position;
    }
}



