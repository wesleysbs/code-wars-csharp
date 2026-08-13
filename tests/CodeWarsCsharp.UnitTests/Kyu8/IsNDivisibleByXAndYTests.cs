using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class IsNDivisibleByXAndYTests
{
    [Theory]
    [InlineData(12, 4, 3, true)]
    [InlineData(3, 3, 4, false)]
    [InlineData(8, 3, 4, false)]
    [InlineData(12, 7, 5, false)]

    public void IsDivisible_GivenThreeIntegers_ShouldReturnCorrectResult(int n, int x, int y, bool expected)
    {
        //Act
        var result = IsNDivisibleByXAndY.IsDivisible(n, x, y);

        //Assert
        Assert.Equal(expected, result);
    }
}