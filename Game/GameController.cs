using System;

class GameController
{
    private readonly IGameUI _ui;
    private readonly Board _board;

    public GameController(IGameUI ui)
    {
        this._ui = ui;
        this._board = new Board();
    }

    /// <summary>
    /// Start the game loop and handle game logic
    /// </summary>
    public void StartGame()
    {
        // draw the initial board
        _ui.DrawBoard(_board);
        // game loop
        bool isGameDone = false;

        while (!isGameDone)
        {
            // get the user input
            int[,] playerMove = _ui.GetPlayerMove();

            // update the board state

            // check the win condition

        }

    }

}
