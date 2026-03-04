using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ThinkfulLogicDrillsTrafficLightTests
{
    [Theory]
    [InlineData("green", "yellow")]
    [InlineData("yellow", "red")]
    [InlineData("red", "green")]

    public void UpdateLight_GivenCurrentColor_ShouldReturnNextColor(string inputValue, string expectedValue)
    {
        //Act
        var result = ThinkfulLogicDrillsTrafficLight.UpdateLight(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
