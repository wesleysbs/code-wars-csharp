using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class GetTheMeanOfAnArrayTests
{
    [Fact]
    public void GetMeanArray_GivenAnArray_ShouldReturnExpectedMeanArray()
    {
        //Arrange
        var inputValue = new int[] { 2, 2, 2, 2 };
        var expectedResult = 2;

        //Act
        var result = GetTheMeanOfAnArray.GetAverage(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}

