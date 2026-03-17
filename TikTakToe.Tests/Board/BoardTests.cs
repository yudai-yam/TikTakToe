using TikTakToe.Board;

namespace TikTakToe.Tests.Board;

public class BoardTests
{
    [Fact]
    public void UpdateBoard_Should_Update_Cell_State()
    {
        // Arrange
        var board = new TikTakToe.Board.Board();
        var move = (row: 1, column: 1);
        var player = CellState.X;

        // Act
        board.UpdateBoard(move, player);

        // Assert
        Assert.Equal(player, board.GetCell(move.row, move.column));
    }

    [Fact]
    public void UpdateBoard_Should_Throw_Exception_When_Cell_Is_Occupied()
    {
        // Arrange
        var board = new TikTakToe.Board.Board();
        var move = (row: 0, column: 0);
        var player1 = CellState.X;
        var player2 = CellState.O;

        board.UpdateBoard(move, player1);

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => board.UpdateBoard(move, player2));
    }   
}