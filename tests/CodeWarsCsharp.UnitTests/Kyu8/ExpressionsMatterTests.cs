using CodeWarsCsharp.Challenges.Kyu8.ExpressionsMatter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ExpressionsMatterTests
{
    [Theory]
    [InlineData(1, 2, 3, 9)]
    [InlineData(9, 1, 1, 18)]

    public void ExpressionsMatter_GivenThreeIntegers_ShouldReturnMaximumValue(int a, int b, int c, int expected)
    {
        //Act
        var result = Kata.ExpressionsMatter(a, b, c);

        //Assert
        Assert.Equal(expected, result);
    }
}
