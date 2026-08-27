using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class OppositeNumberTests
{
    [Theory]
    [InlineData(1, -1)]
    [InlineData(25, -25)]
    [InlineData(0, 0)]
    [InlineData(-10, 10)]

    public void Opposite_GivenANumber_ShouldReturnItsOpposite(int number, int expected)
    {
        //Act
        var result = OppositeNumber.Opposite(number);

        //Assert
        Assert.Equal(expected, result);
    }
}