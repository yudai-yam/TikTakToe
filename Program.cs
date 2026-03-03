class Program
{
    static void Main()
    {
        Console.WriteLine("Game started");

        // start the Game 
        ConsoleUI ui = new ConsoleUI();

        GameController gameController = new GameController(ui);
        gameController.StartGame();

    }
}