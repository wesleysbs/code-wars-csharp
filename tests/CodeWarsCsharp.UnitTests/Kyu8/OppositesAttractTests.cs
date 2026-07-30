using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class OppositesAttractTests
{
    [Theory]
    [InlineData(1, 4, true)]
    [InlineData(2, 2, false)]
    [InlineData(3, 5, false)]
    [InlineData(6, 7, true)]

    public void LoveFunc_GivenTwoIntegers_ShouldReturnExpectedResult(int flower1, int flower2, bool expected)
    {
        //Act
        var result = OppositesAttract.LoveFunc(flower1, flower2);

        //Assert
        Assert.Equal(expected, result);
    }
}