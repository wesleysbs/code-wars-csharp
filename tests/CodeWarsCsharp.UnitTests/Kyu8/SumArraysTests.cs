using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SumArraysTests
{
    [Theory]
    [InlineData(null, 0.0)]
    [InlineData(new double[] { 1, 5.2, 4, 0, -1 }, 9.2)]

    public void SumArray_GivenArray_ShouldReturnCorrectSum(double[]? inputValue, double expectedValue)
    {
        //Act
        var result = SumArrays.SumArray(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
