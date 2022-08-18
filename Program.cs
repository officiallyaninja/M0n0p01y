using M0n0p01y;

var players = new List<Player> { new Player(ConsoleColor.Blue), new Player(ConsoleColor.Red), new Player(ConsoleColor.Green), new Player(ConsoleColor.Yellow) };

var board = new Board(players);
var game = new GameManager(players);


while (true)
{
    Console.Clear();
    board.ShowBoard();
    var roll = game.RollDiceAndMove();
    Console.WriteLine();
    Console.WriteLine(roll);
    Console.ReadKey();

}