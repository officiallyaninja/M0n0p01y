namespace M0n0p01y;

public abstract record Space(string name, SpaceType type, int position)
{
    public SpaceType Type = type;
    public int Position = position;
    
}


public enum SpaceType
{
    Property,
    RailRoad,
    Utility,
    Go,
    Chance,
    CommunityChest,
    IncomeTax,
    LuxuryTax,
    FreeParking,
    GoToJail,
    Jail,
}