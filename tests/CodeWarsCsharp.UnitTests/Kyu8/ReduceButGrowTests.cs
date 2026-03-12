using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ReduceButGrowTests
{
    [Fact]

    public void ReduceButGrow_GivenAnArray_ShouldReturnCorrectProduct()
    {
        //Arrange
        var inputValue = new int[] { 4, 1, 1, 1, 4 };
        var expectedValue = 16;

        //Act
        var result = ReduceButGrow.Grow(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
