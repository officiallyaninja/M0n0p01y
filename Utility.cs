namespace M0n0p01y;

public record Utility(string Name, int mortgageValue) : Space
{
    public string Name = Name;
    public int MortgageValue = mortgageValue;
}
