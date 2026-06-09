using CodeWarsCsharp.Challenges.Kyu8.Hero;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class IsHeGonnaSurviveTests
{
    [Theory]
    [InlineData(10, 5, true)]
    [InlineData(100, 40, true)]
    [InlineData(4, 5, false)]
    [InlineData(0, 1, false)]

    public void Hero_GivenBulletsAndDragons_ShouldReturnExpectedResult(int bullets, int dragons, bool expected)
    {
        //Act
        var result = Kata.Hero(bullets, dragons);

        //Assert
        Assert.Equal(expected, result);
    }
}
