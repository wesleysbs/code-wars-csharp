using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SumOfPositiveTests
{
    [Theory]
    [InlineData(new int[]{1, 2, 3, 4, 5}, 15)]
    [InlineData(null, 0)]
    
    public void SumOfPositive_GivenAnArray_ShouldExpectedPositiveSum(int[] inputValue, int expectedValue)
    {
        //Act
        var result = SumOfPositive.PositiveSum(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
