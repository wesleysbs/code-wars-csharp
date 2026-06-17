using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class TheFallingSpeedOfPetalsTests
{
    [Theory]
    [InlineData(0.0,0.0)]
    [InlineData(-1.0,0.0)]
    [InlineData(5.0, 80.0)]
    [InlineData(10.0, 40.0)]
    [InlineData(20.0, 20.0)]

    public void SakuraFall_GivenVelocity_ShouldReturnExpectedTime(double v, double expected)
    {
        //Act
        var result = TheFallingSpeedOfPetals.SakuraFall(v);

        //Assert
        Assert.Equal(expected, result);
    }
}