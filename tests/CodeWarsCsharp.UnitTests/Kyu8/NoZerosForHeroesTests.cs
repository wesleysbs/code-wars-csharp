using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class NoZerosForHeroesTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(1450, 145)]
    [InlineData(960000, 96)]
    [InlineData(1050, 105)]
    [InlineData(-1050, -105)]

    public void NoBoringZeros_GivenANumber_ShouldRemoveTrailingZeros(int number, int expected)
    {
        //Act
        var result = NoZerosForHeroes.NoBoringZeros(number);

        //Assert
        Assert.Equal(expected, result);
    }
}