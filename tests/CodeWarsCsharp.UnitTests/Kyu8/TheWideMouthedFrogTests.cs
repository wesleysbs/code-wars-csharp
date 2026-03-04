using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class TheWideMouthedFrogTests
{
    [Theory]
    [InlineData("alligator", "small")]
    [InlineData("ALLIGATOR", "small")]
    [InlineData("ant bear", "wide")]

    public void MouthSize_GivenAnimal_ShouldReturnCorrectMouthSize(string inputValue, string expectedValue)
    {
        //Act
        var result = TheWideMouthedFrog.MouthSize(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
