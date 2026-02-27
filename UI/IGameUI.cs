using System;
using System.Reflection.Metadata;

interface IGameUI
{
    // Define methods for the game UI here
    int GetUserInput();
    void DrawBoard(Board board);
    void ShowMessage(string message);
}
