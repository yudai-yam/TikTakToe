using System;

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
}