using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class TwiceAsOldTests
{
    [Theory]
    [InlineData(30, 0, 30)]
    [InlineData(30, 7, 16)]
    [InlineData(45, 30, 15)]

    public void TwiceAsOld_GivenDadYearsAndSonYears_ShouldReturnYearsUntilTwiceAsOld(int dadYears, int sonYears, int expected)
    {
        //Act
        var result = TwiceAsOldSolution.TwiceAsOld(dadYears, sonYears);

        //Assert
        Assert.Equal(expected, result);
    }
}
