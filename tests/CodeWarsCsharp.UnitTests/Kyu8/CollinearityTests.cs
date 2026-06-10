using CodeWarsCsharp.Challenges.Kyu8.Collinearity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class CollinearityTests
{
    [Theory]
    [InlineData(1, 1, 1, 1, true)]
    [InlineData(1, 1, 6, 1, false)]
    [InlineData(1, -2, -2, 4, true)]
    [InlineData(1, 2, 1, -2, false)]
    [InlineData(0, 0, 0, 0, true)]
    [InlineData(0, 1, 6, 0, false)]

    public void Collinearity_GivenVectorCoordinates_ShouldReturnExpectedResult(int x1, int y1, int x2, int y2, bool expected)
    {
        //Act
        var result = Kata.Collinearity(x1, y1, x2, y2);

        //Assert
        Assert.Equal(expected, result);
    }
}
