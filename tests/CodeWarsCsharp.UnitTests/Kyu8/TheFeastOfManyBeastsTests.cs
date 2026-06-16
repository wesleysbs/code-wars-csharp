using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class TheFeastOfManyBeastsTests
{
    [Theory]
    [InlineData("great blue heron", "garlic naan", true)]
    [InlineData("chickadee", "chocolate cake", true)]
    [InlineData("brown bear", "bear claw", false)]
    [InlineData("fox", "fish", false)]

    public void Feast_GivenBeastAndDish_ShouldReturnExpectedResult(string beast, string dish, bool expected)
    {
        //Act
        var result = TheFeastOfManyBeasts.Feast(beast, dish);

        //Assert
        Assert.Equal(expected, result);
    }
}