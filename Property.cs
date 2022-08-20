namespace M0n0p01y;

public record Property(string name, SpaceType type, int position, int mortgageValue, int cost) : Buyable(name, SpaceType.Property, position,  mortgageValue, cost)
{
    public override int CalculateRent()
    {
        throw new NotImplementedException();
    }
}
