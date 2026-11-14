using MathLib;
using Xunit;

namespace MathLib.Tests;

public class MathOperationsTests
{
    [Fact]
    public void Factorial_Of5_Returns120()
    {
        Assert.Equal(120, MathOperations.Factorial(5));
    }

    [Fact]
    public void Factorial_OfZero_ReturnsOne()
    {
        Assert.Equal(1, MathOperations.Factorial(0));
    }

    [Fact]
    public void Factorial_OfOne_ReturnsOne()
    {
        Assert.Equal(1, MathOperations.Factorial(1));
    }

    [Fact]
    public void Factorial_Of20_ReturnsCorrectValue()
    {
        Assert.Equal(2432902008176640000L, MathOperations.Factorial(20));
    }

    [Fact]
    public void Factorial_OfNegative_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => MathOperations.Factorial(-1));
    }

    [Fact]
    public void Factorial_OfTooLarge_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => MathOperations.Factorial(21));
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(7, false)]
    [InlineData(0, true)]
    [InlineData(-4, true)]
    [InlineData(-3, false)]
    public void IsEven_ReturnsExpected(int number, bool expected)
    {
        Assert.Equal(expected, MathOperations.IsEven(number));
    }
}