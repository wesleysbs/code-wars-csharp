using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class GrasshopperArrayMeanTests
{
    [Fact]
    public void GetMeanArray_GivenArrayOfIntegers_ShouldReturnCorrectMean()
    {
        //Arrange
        var inputValue = new int[] { 1, 3, 5, 7 };
        var expectedResult = 4;

        //Act
        var result = GrasshopperArrayMean.FindAverage(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
