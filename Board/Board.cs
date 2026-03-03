using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Board
{
    private CellState[,] grid;

    public Board()
    {
        grid = new CellState[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                grid[i, j] = CellState.Empty;
            }
        }
        
    }

    public CellState[,] GetGrid()
    {
        return grid;
    }  

    public void UpdateBoard((int row, int column) move, CellState player)
    {
        int row = move.row;
        int column = move.column;

        CellState target_cell = grid[row, column];

        if (target_cell == CellState.Empty)
        {
            grid[row, column] = player;
        }
        else
        {
            throw new InvalidOperationException($"Cell is already occupied by {target_cell}");
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
        bool has_winner = false;

        // vertical
        for (int i=0; i<3; i++)
        {
            if (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i] && grid[0, i] != CellState.Empty)
            {
                has_winner = true;
                return has_winner;
            }
        }

        // horizontal
        for (int i=0; i<3; i++)
        {
            if (grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2] && grid[i, 0] != CellState.Empty)
            {
                has_winner = true;
                return has_winner;
            }
        }

        // diagonal
        if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] != CellState.Empty)
        {
            has_winner = true;
            return has_winner;
        }

        if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0] && grid[0, 2] != CellState.Empty)
        {
            has_winner = true;
            return has_winner;
        }

        return has_winner;
    }
}