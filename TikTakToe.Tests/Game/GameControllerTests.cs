using TikTakToe.Game;

namespace TikTakToe.Tests.Game;

public class GameControllerTests
{
    [Fact]
    public void StartGame_Should_Handle_Game_Logic_Correctly()
    {
        // Arrange
        var mockUI = new Mock<IGameUI>();
        var gameController = new GameController(mockUI.Object);

        // Simulate user input for a winning scenario
        var inputSequence = new Queue<(int, int)>();
        inputSequence.Enqueue((0, 0)); // Player X
        inputSequence.Enqueue((1, 0)); // Player O
        inputSequence.Enqueue((0, 1)); // Player X
        inputSequence.Enqueue((1, 1)); // Player O
        inputSequence.Enqueue((0, 2)); // Player X wins

        mockUI.Setup(ui => ui.GetPlayerMove()).Returns(() => inputSequence.Dequeue());

        // Act
        gameController.StartGame();

        // Assert
        mockUI.Verify(ui => ui.ShowMessage("Player X wins!"), Times.Once);
    } 
}