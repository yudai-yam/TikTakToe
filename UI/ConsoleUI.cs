using System;

/// <summary>
/// implement interface IGameUi, responsible for console actions.
/// </summary>
class ConsoleUI : IGameUI
{
    public ConsoleUI()
    {
        Console.WriteLine("Console UI constructor initialized");
    }

    public void DrawBoard(Board board)
    {
        Console.WriteLine("Drawing the board");
    }

    public int[,] GetPlayerMove()
    {
        // ask for row
        Console.WriteLine("Please enter the row (0, 1, or 2):");
        int row = InputValidation.GetUserIntInput();

        // ask for column
        Console.WriteLine("Please enter the column (0, 1, or 2):");
        int column = InputValidation.GetUserIntInput();

        int[,] input = { { row, column } };
        
        return input;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}