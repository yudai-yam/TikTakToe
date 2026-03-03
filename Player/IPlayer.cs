namespace TikTakToe.Player;
using TikTakToe.Board;

public interface IPlayer
{
    (int row, int column) GetMove(Board board);
}
