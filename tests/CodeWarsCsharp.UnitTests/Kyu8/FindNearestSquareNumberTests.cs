using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class FindNearestSquareNumberTests
{
    [Theory]
    [InlineData(1,1)]
    [InlineData(2,1)]
    [InlineData(10, 9)]
    [InlineData(111, 121)]
    [InlineData(9999, 10000)]

    public void NearestSq_GivenAnInteger_ShouldReturnExpectedResult(int n, int expected)
    {
        //Act
        var result = FindNearestSquareNumber.NearestSq(n);

        //Assert
        Assert.Equal(expected, result);
    }
}