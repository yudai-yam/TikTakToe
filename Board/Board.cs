namespace TikTakToe.Board;

public class Board
{
    private CellState[,] _grid;
    public const int Size = 3;

    public Board()
    {
        _grid = new CellState[Size, Size];
    }

    public CellState GetCell(int row, int column)
    {
        return _grid[row, column];
    }

    public void UpdateBoard((int row, int column) move, CellState player)
    {
        int row = move.row;
        int column = move.column;

        CellState targetCell = _grid[row, column];

        if (targetCell == CellState.Empty)
        {
            _grid[row, column] = player;
        }
        else
        {
            throw new InvalidOperationException($"Cell is already occupied by {targetCell}");
        }

    }

    /// <summary>
    /// Check if there is a winner on the board
    /// </summary>
    /// <returns>
    /// True if there is a winner, false otherwise
    /// </returns>
    public bool HasWinner()
    {
        // vertical
        for (int i=0; i<Size; i++)
        {
            if (_grid[0, i] == _grid[1, i] && _grid[1, i] == _grid[2, i] && _grid[0, i] != CellState.Empty)
            {
                return true;
            }
        }

        // horizontal
        for (int i=0; i<Size; i++)
        {
            if (_grid[i, 0] == _grid[i, 1] && _grid[i, 1] == _grid[i, 2] && _grid[i, 0] != CellState.Empty)
            {
                return true;
            }
        }

        // diagonal
        if (_grid[0, 0] == _grid[1, 1] && _grid[1, 1] == _grid[2, 2] && _grid[0, 0] != CellState.Empty)
        {
            return true;
        }

        if (_grid[0, 2] == _grid[1, 1] && _grid[1, 1] == _grid[2, 0] && _grid[0, 2] != CellState.Empty)
        {
            return true;
        }

        return false;
    }

    public bool IsFull()
    {
        for (int i=0; i<Size; i++)
        {
            for (int j=0; j<Size; j++)
            {
                if (_grid[i, j] == CellState.Empty)
                {
                    return false;
                }
            }
        }
        return true;
    }
}