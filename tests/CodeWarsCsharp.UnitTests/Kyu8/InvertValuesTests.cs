using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class InvertValuesTests
{
    [Fact]

    public void InvertValues_GivenIntegerArray_ShouldReturnInvertedArray()
    {
        //Arrange
        var inputValue = new int[] {1, -2, 3, -4, 5};
        var expectedValue = new int[] {-1, 2, -3, 4, -5};

        //Act
        var result = Invert.InvertValues(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}