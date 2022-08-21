namespace M0n0p01y;

public record Utility(string name, int position, int mortgageValue, int cost) : Property(name, SpaceType.Utility, position,  mortgageValue, cost)
{

    public override int CalculateRent()
    {
        _ = Owner ?? throw new InvalidOperationException("Owner is null");
        return Owner.Utilities.Count switch
        {
            1 => Owner.LastRoll * 4,
            2 => Owner.LastRoll * 10,
            _ => throw new InvalidOperationException(
                "how the fuck does this player have more than 2 or less than 1 utilities????")
        };
    }
}
