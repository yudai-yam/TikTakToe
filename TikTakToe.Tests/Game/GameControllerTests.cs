using TikTakToe.Game;
using Moq;
using TikTakToe.UI;
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

        // setup the mock for the GetPlayerMove()
        // execute the lamda function every time GetPlayerMove() is called to return the next input from the queue
        // if .Returns(inputSequence.Dequeue(), it would execute the Dequeue() only the first time
        // it would return (0,0) for all subsequent calls
        mockUI.Setup(ui => ui.GetPlayerMove()).Returns(() => inputSequence.Dequeue());

        // Act
        gameController.StartGame();

        // Assert
        // Times.Once means exactly 1 time
        // verify that ShowMessage was called with "Player X wins!" exactly once
        mockUI.Verify(ui => ui.ShowMessage("Player X wins!"), Times.Once);
    } 
}