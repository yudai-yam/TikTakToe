namespace TikTakToe.UI;
using TikTakToe.Board;
using TikTakToe.Utils;

/// <summary>
/// implement interface IGameUi, responsible for console actions.
/// </summary>
internal class ConsoleUI : IGameUI
{
    public void DrawBoard(Board board)
    {
        CellState[,] grid = board.GetGrid();
        Console.WriteLine("+---+---+---+");
        for (int r=0; r<Board.Size; r++)
        {
            for (int c=0; c<Board.Size; c++)
            {
                Console.Write($"| {((grid[r, c] == CellState.Empty) ? ' ' : grid[r, c])} ");
            }
            Console.WriteLine("|\n+---+---+---+");
        }
    }

    public (int row, int column) GetPlayerMove()
    {
        // ask for row
        Console.WriteLine("Please enter the row (0, 1, or 2):");
        int row = InputValidation.GetUserIntInput();

        // ask for column
        Console.WriteLine("Please enter the column (0, 1, or 2):");
        int column = InputValidation.GetUserIntInput();

        return (row, column);
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}