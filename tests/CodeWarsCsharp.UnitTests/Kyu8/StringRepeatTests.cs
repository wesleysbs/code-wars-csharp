using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class StringRepeatTests
{
    [Theory]
    [InlineData(3, "*", "***")]
    [InlineData(4, "", "")]
    [InlineData(5, "Hello", "HelloHelloHelloHelloHello")]
    [InlineData(0, "mystery", "")]

    public void RepeatStr_GivenCountAndString_ShouldReturnRepeatedString(int n, string s, string expected)
    {
        //Act
        var result = StringRepeat.RepeatStr(n, s);

        //Assert
        Assert.Equal(expected, result);
    }
}