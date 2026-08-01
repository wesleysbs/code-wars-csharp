using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ReturnNegativeTests
{
    [Theory]
    [InlineData(1, -1)]
    [InlineData(-5, -5)]
    [InlineData(0, 0)]

    public void MakeNegative_GivenAnInteger_ShouldReturnNegativeValue(int number, int expected)
    {
        //Act
        var result = ReturnNegative.MakeNegative(number);

        //Assert
        Assert.Equal(expected, result);
    }
}