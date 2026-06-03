using CodeWarsCsharp.Challenges.Kyu8.TotalPoints;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class TotalAmountOfPointsTests
{
    [Theory]
    [InlineData(new string[] {"1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3"}, 30)]
    [InlineData(new string[] { "0:1", "0:2", "0:3", "0:4", "1:2", "1:3", "1:4", "2:3", "2:4", "3:4" }, 0)]
    [InlineData(new string[] { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" }, 10)]

    public void TotalPoints_GivenGameResults_ShouldReturnExpectedPoints(string[] games, int expected)
    {
        //Act
        var result = Kata.TotalPoints(games);

        //Assert
        Assert.Equal(expected, result);
    }
}
