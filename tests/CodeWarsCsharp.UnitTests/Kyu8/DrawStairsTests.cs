using CodeWarsCsharp.Challenges.Kyu8.DrawStairs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class DrawStairsTests
{
    [Theory]
    [InlineData(1, "I")]
    [InlineData(2, "I\n I")]
    [InlineData(3, "I\n I\n  I")]
    [InlineData(4, "I\n I\n  I\n   I")]
    public void DrawStairs_GivenNumberOfSteps_ShouldReturnCorrectStairPattern(int n, string expected)
    {
        //Act
        var result = Kata.DrawStairs(n);

        //Assert
        Assert.Equal(expected, result);
    }
}