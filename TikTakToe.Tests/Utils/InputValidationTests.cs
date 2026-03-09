using Xunit;
using TikTakToe.Utils;

namespace TikTakToe.Tests.Utils
{
    public class InputValidationTests
    {
        // Define a data source
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { "1", 1 };
            yield return new object[] { "0", 0 };
            yield return new object[] { "2", 2 };
            yield return new object[] { "e\n3\n2", 2 };
            yield return new object[] { "e\n1", 1 };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void GetUserIntInput_Should_Return_Correct_Number(string input, int? expected)
        {
            // Arrange
            var stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            // Act
            int result = InputValidation.GetUserIntInput();

            // Assert
            if (expected.HasValue)
            {
                Assert.Equal(expected.Value, result);
            }
            else
            {
                Assert.True(result < 0 || result > 2, "Expected an invalid input.");
            }
        }
    }
}