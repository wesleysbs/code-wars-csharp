using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class GetPlanetNameByIdTests
{
    [Theory]
    [InlineData(1, "Mercury")]
    [InlineData(2, "Venus")]
    [InlineData(3, "Earth")]
    [InlineData(4, "Mars")]
    [InlineData(5, "Jupiter")]
    [InlineData(6, "Saturn")]
    [InlineData(7, "Uranus")]
    [InlineData(8, "Neptune")]

    public void GetPlanetName_GivenAnId_ShouldReturnCorrectPlanet(int id, string expected)
    {
        //Act
        var result = GetPlanetNameById.GetPlanetName(id);

        //Assert
        Assert.Equal(expected, result );
    }

    [Fact]
    
    public void GetPlanetName_GivenInvalidId_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        GetPlanetNameById.GetPlanetName(9));
    }
}