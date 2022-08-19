namespace M0n0p01y;

public record Utility(string name, int mortgageValue, SpaceType type, int position) : Space(type, position)
{
    public string Name = name;
    public int MortgageValue = mortgageValue;
}
