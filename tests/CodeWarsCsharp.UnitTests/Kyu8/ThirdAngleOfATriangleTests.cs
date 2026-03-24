using CodeWarsCsharp.Challenges.Kyu8.ThirdAngle;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ThirdAngleOfATriangleTests
{
    [Theory]
    [InlineData(30, 60, 90)]
    [InlineData(60, 60, 60)]
    [InlineData(43, 78, 59)]
    [InlineData(10, 20, 150)]

    public void OtherAngle_GivenTwoAngles_ShouldReturnThirdAngle(int angle1, int angle2, int expected)
    {
        //Act
        var result = Kata.OtherAngle(angle1, angle2);

        //Assert
        Assert.Equal(expected, result);
    }
}
