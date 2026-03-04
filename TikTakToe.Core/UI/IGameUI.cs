namespace TikTakToe.UI;
using TikTakToe.Board;

public interface IGameUI
{
    // Define methods for the game UI here
    (int row, int column) GetPlayerMove();
    void DrawBoard(Board board);
    void ShowMessage(string message);
}
