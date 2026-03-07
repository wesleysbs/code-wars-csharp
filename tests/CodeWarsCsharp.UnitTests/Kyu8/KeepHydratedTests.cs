using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class KeepHydratedTests
{
    [Theory]
    [InlineData(2.0,1)]
    [InlineData(12.6, 6)]
    [InlineData(0.82, 0)]
    [InlineData(1787.0, 893)]
    [InlineData(0.0, 0)]
    public void Litres_GivenTime_ShouldReturnCorrectLitres(double inputValue, int expectedValue)
    {
        //Act
        var result = KeepHydrated.Litres(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
