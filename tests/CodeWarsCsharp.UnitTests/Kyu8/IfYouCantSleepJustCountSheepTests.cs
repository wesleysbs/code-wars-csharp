using CodeWarsCsharp.Challenges.Kyu8.CountSheep;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class IfYouCantSleepJustCountSheepTests
{
    [Theory]
    [InlineData(0, "")]
    [InlineData(1, "1 sheep...")]
    [InlineData(2, "1 sheep...2 sheep...")]
    [InlineData(3, "1 sheep...2 sheep...3 sheep...")]

    public void CountSheep_GivenPositiveNumber_ShouldReturnExpectedResult(int n, string expected)
    {
        //Act
        var result = Kata.CountSheep(n);

        //Assert
        Assert.Equal(expected, result);
    }
}
