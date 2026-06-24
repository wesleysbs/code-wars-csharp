using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class CountOddNumbersBelowNTests
{
    [Theory]
    [InlineData(7, 3)]
    [InlineData(15, 7)]
    [InlineData(15023, 7511)]
    [InlineData(0, 0)]
    [InlineData(1, 0)]

    public void OddCount_GivenANumber_ShouldReturnCountOfOddNumbersBelow(ulong n, ulong expected)
    {
        //Act
        var result = CountOddNumbersBelowN.OddCount(n);

        //Assert
        Assert.Equal(expected, result);
    }
}