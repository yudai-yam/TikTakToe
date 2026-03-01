using System;

public enum Player
{
    Player1,
    Player2
}

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

    public void UpdateBoard(int[,] move, Player player)
    {
        int row = move[0, 0];
        int column = move[0, 1];

        if (player == Player.Player1)
        {
            grid[row, column] = CellState.X;
        }
        else
        {
            grid[row, column] = CellState.O;
        }
    }
}