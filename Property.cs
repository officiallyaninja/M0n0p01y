namespace M0n0p01y;

public abstract record Property(string name, SpaceType type, int position, int mortgageValue, int cost) : Space(name, type, position)
{
    public int Cost { get; } = cost;
    public int MortgageValue { get; set; } = mortgageValue;
    public bool isMortgaged { get; set; }
    public Player? Owner { get; set; } = null;

    public void Mortgage()
    {
        if (!isMortgaged) throw new InvalidOperationException("Property already mortgaged");
        if (Owner == null) throw new InvalidOperationException("Owner is null");

        isMortgaged = true;
        Owner.Money += MortgageValue;
    }
    public void UnMortgage()
    {
        if (isMortgaged) throw new InvalidOperationException("Property is not already mortgaged");
        if (Owner == null) throw new InvalidOperationException("Owner is null");

        isMortgaged = false;
        Owner.Money -= MortgageValue;
    }
    public abstract int CalculateRent();

}
