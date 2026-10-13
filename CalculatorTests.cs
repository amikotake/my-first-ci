using Xunit;

namespace DotNetTest;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSum_WhenGivenTwoIntegers()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Add(3, 5);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_ReturnsDifference_WhenGivenTwoIntegers()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var result = calculator.Subtract(10, 4);

        // Assert
        Assert.Equal(6, result);
    }
}