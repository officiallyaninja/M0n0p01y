namespace M0n0p01y;

public class Board
{
    private const string _spaces = "G#C#TR#c##J#U##R#C##F#c##R##u#j##C#Rc#t#";

    public void ShowBoard(int verticalOffset, int horizontalOffset)
    {
        var horizontalPadding = new string(' ', horizontalOffset);
        var internalPadding = new string(' ', 9);
        Console.Write(new string('\n', verticalOffset));
        Console.WriteLine(horizontalPadding +_spaces[..11]);
        for (int i = 0; i < 9; i++)
        {
            Console.Write(horizontalPadding);
            Console.WriteLine(_spaces[11+i] + internalPadding + _spaces[^(i+1)]);
        }
        Console.WriteLine(horizontalPadding + new string(_spaces[20..31].Reverse().ToArray()));

    }

}
