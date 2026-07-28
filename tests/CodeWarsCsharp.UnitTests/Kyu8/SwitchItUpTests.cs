using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SwitchItUpTests
{
    [Theory]
    [InlineData(0, "Zero")]
    [InlineData(9, "Nine")]
    [InlineData(5, "Five")]

    public void NumberToWord__GivenAValidNumber_ShouldReturnCorrespondingWord(int number, string expected)
    {
        //Act
        var result = SwitchItUp.NumberToWord(number);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void NumberToWord_GivenInvalidNumber_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            SwitchItUp.NumberToWord(15));
    }
}