using CodeWarsCsharp.Challenges.Kyu8.Quadrants;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class QuadrantsTests
{
    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(3, 5, 1)]
    [InlineData(-10, 100, 2)]
    [InlineData(-1, -9, 3)]
    [InlineData(19, -56, 4)]
    [InlineData(1, 1, 1)]
    [InlineData(-60, -12, 3)]

    public void Quadrants_GivenXAndY_ShouldReturnCorrectQuadrant(int x, int y, int expected)
    {
        //Act
        var result = Kata.Quadrant(x, y);

        //Assert
        Assert.Equal(expected, result);
    }
}
