class GameController
{
    private readonly IGameUI _ui;
    private readonly Board _board;
    private CellState _currentPlayer = CellState.X;

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

        while (true)
        {
            _ui.ShowMessage($"Player {_currentPlayer}'s turn.");

            // get the user input
            (int row, int column) playerMove = _ui.GetPlayerMove();

            // update the board state
            try
            {
                _board.UpdateBoard(playerMove, _currentPlayer);
            }
            catch (Exception e)
            {
                _ui.ShowMessage(e.Message); 
                continue;    
            }

            // show current board state
            _ui.DrawBoard(_board);

            // check the win condition
            if (_board.HasWinner())
            {
                _ui.ShowMessage($"Player {_currentPlayer} wins!");
                break;
            }

            // check if it is full
            if (_board.IsFull())
            {
                _ui.ShowMessage("It's a draw!");
                break;
            }

            // switch player
            _currentPlayer = _currentPlayer == CellState.X ? CellState.O : CellState.X;

        }
    }
}