using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class DrinkAboutTests
{
    [Theory]
    [InlineData(13, "drink toddy")]
    [InlineData(14, "drink coke")]
    [InlineData(18, "drink beer")]
    [InlineData(21, "drink whisky")]


    public void PeopleWithAgeDrink_GivenPeopleAge_ShouldReturnSuitableDrink(int old, string expected)
    {
        //Act
        var result = DrinkAbout.PeopleWithAgeDrink(old);

        //Assert
        Assert.Equal(expected, result);
    }
}