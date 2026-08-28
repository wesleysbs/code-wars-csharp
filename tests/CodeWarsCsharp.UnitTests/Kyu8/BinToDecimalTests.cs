using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class BinToDecimalTests
{
    [Theory]
    [InlineData("0", 0)]
    [InlineData("1", 1)]
    [InlineData("10", 2)]
    [InlineData("110", 6)]

    public void BinToDec_GivenABinaryString_ShouldReturnTheDecimalNumber(string s, int expected)
    {
        //Act
        var result = BinToDecimal.BinToDec(s);

        //Assert
        Assert.Equal(expected, result);
    }
}