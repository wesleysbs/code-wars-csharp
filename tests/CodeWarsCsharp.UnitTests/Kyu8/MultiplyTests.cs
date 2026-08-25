using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class MultiplyTests
{
    [Theory]
    [InlineData(0, 2, 0)]
    [InlineData(5, 6, 30)]
    [InlineData(-5, 6, -30)]
    [InlineData(-5, -6, 30)]

    public void Multiply_GivenTwoNumbers_ShouldReturnTheCorrectMultiplication (int a, int b, int expected)
    {
        //Act
        var result = CustomMath.Multiply(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
}