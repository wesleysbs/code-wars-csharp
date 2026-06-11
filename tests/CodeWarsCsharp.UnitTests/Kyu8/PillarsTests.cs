using CodeWarsCsharp.Challenges.Kyu8.Pillars;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class PillarsTests
{
    [Theory]
    [InlineData(1, 10, 10, 0)]
    [InlineData(2, 20, 25, 2000)]
    [InlineData(11, 15, 30, 15270)]

    public void Pillars_GivenNumberOfPillarsDistanceAndWidth_ShouldReturnDistanceInCentimeters(int numPill, int dist, int width, int expected)
    {
        //Act
        var result = Kata.Pillars(numPill, dist, width);

        //Assert
        Assert.Equal(expected, result);
    }
}