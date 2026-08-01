using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class KeepUpTheHoopTests
{
    [Theory]
    [InlineData(10, "Great, now move on to tricks")]
    [InlineData(9, "Keep at it until you get it")]
    [InlineData(22, "Great, now move on to tricks")]
    [InlineData(0, "Keep at it until you get it")]

    public void HoopCount_GivenNumberOfHoops_ShouldReturnCorrectMessage(int n, string expected)
    {
        //Act
        var result = KeepUpTheHoop.HoopCount(n);

        //Assert
        Assert.Equal(expected, result);
    }
}