namespace TikTakToe;
using TikTakToe.UI;
using TikTakToe.Game;

class Program
{
    static void Main()
    {
        Console.WriteLine("Game started");

        // start the Game 
        IGameUI ui = new ConsoleUI();

        GameController gameController = new GameController(ui);
        gameController.StartGame();

    }
}