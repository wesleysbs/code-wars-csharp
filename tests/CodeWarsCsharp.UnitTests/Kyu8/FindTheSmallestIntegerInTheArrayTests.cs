using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class FindTheSmallestIntegerInTheArrayTests
{
    [Fact]
    public void FindSmallestInt_GivenAArray_ShouldReturnExpectedSmallestInteger()
    {
        //Arrange
        var inputIntValue = new int[] { 34, 15, 88, 2 };
        var expectedResult = 2;

        //Act
        var result = FindTheSmallestIntegerInTheArray.FindSmallestInt(inputIntValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
