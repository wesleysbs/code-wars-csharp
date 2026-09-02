using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class EvenOrOddTests
{
    [Theory]
    [InlineData(1, "Odd")]
    [InlineData(4, "Even")]
    [InlineData(37, "Odd")]
    [InlineData(0, "Even")]
    [InlineData(-5, "Odd")]

    public void CheckEvenOrOdd_GivenANumber_ShouldReturnCorrectParity(int number, string expected)
    {
        //Act
        var result = EvenOrOdd.CheckEvenOrOdd(number);

        //Assert
        Assert.Equal(expected, result);
    }
}