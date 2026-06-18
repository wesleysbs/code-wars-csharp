using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SumTheStringsTests
{
    [Theory]
    [InlineData("", "9", "9")]
    [InlineData("8", "", "8")]
    [InlineData("", "", "0")]
    [InlineData("4", "5", "9")]
    [InlineData("34", "5", "39")]
    [InlineData("-5", "3", "-2")]
    [InlineData(null, "3", "3")]
    [InlineData("3", null, "3")]
    [InlineData(null, null, "0")]

    public void StringsSum_WhenGivenNumericOrEmptyStrings_ReturnsSumAsString(string s1, string s2, string expected)
    {
        //Act
        var result = SumTheStrings.StringsSum(s1, s2);

        //Assert
        Assert.Equal(expected, result);
    }
}