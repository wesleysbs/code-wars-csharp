using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SumOfDifferencesInArrayTests
{
    [Fact]
    public void SumOfDifferences_GivenAnEmptyArray_ShouldReturnZero()
    {
        //Arrange
        var inputValue = new int[] { };
        var expectedResult = 0;

        //Act
        var result = SumOfDifferencesInArray.SumOfDifferences(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void SumOfDifferences_GivenAnArrayWithSingleElement_ShouldReturnZero()
    {
        //Arrange
        var inputValue = new int[] {1};
        var expectedResult = 0;

        //Act
        var result = SumOfDifferencesInArray.SumOfDifferences(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void SumOfDifferences_GivenAnArrayOfIntegers_ShouldReturnCorrectSum()
    {
        //Arrange
        var inputValue = new int[] {0, 29, 24, 17};
        var expectedResult = 29;

        //Act
        var result = SumOfDifferencesInArray.SumOfDifferences(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}