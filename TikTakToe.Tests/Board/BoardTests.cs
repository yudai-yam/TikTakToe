using Newtonsoft.Json.Converters;
using TikTakToe.Board;

namespace TikTakToe.Tests.Board;

public class BoardTests
{
    // Define a data source
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[] { (row: 1, column: 1) };
        yield return new object[] { (row: 0, column: 0) };
        yield return new object[] { (row: 2, column: 2) };
        yield return new object[] { (row: 1, column: 0) };
        yield return new object[] { (row: 0, column: 1) };
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void UpdateBoard_Should_Update_Cell_State((int row, int column) move)
    {
        // Arrange
        var board = new TikTakToe.Board.Board();
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

    [Fact]
    public void HasWnnter_Should_Return_True_When_There_Is_A_Winner()
    {
        // arrange
        var board = new TikTakToe.Board.Board();
        board.UpdateBoard((0, 0), CellState.X);
        board.UpdateBoard((0, 1), CellState.X);
        board.UpdateBoard((0, 2), CellState.X);

        // act
        var hasWinner = board.HasWinner();

        // assert
        Assert.True(hasWinner);

    }

    [Fact]
    public void HasWnnter_Should_Return_False_When_There_Is_No_Winner()
    {
        // arrange
        var board = new TikTakToe.Board.Board();
        board.UpdateBoard((0, 0), CellState.X);
        board.UpdateBoard((0, 1), CellState.X);
        board.UpdateBoard((1, 2), CellState.X);

        // act
        var hasWinner = board.HasWinner();

        // assert
        Assert.False(hasWinner);

    }

    [Fact]
    public void IsFull_Should_Return_True_When_Board_Is_Full()
    {
        // arrange
        var board = new TikTakToe.Board.Board();
        board.UpdateBoard((0, 0), CellState.X);
        board.UpdateBoard((0, 1), CellState.X);
        board.UpdateBoard((0, 2), CellState.X);
        board.UpdateBoard((1, 0), CellState.X);
        board.UpdateBoard((1, 1), CellState.X);
        board.UpdateBoard((1, 2), CellState.X);
        board.UpdateBoard((2, 0), CellState.X);
        board.UpdateBoard((2, 1), CellState.X);
        board.UpdateBoard((2, 2), CellState.X);

        // act
        var isFull = board.IsFull();

        // assert
        Assert.True(isFull);
    }
}