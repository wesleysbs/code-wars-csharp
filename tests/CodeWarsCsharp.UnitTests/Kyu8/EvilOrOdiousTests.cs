using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class EvilOrOdiousTests
{
    [Theory]

    [InlineData(1, "It's Odious!")]
    [InlineData(3, "It's Evil!")]
    [InlineData(7, "It's Odious!")]
    [InlineData(10, "It's Evil!")]

    public void EvilOrOdious_GivenAnInteger_ShouldReturnCorrectMessage(int n, string expected)
    {
        //Act
        var result = EvilOrOdious.Evil(n);

        //Assert
        Assert.Equal(expected, result);
    }
}