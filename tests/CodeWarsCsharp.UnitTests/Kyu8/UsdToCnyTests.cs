using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class UsdToCnyTests
{
    [Theory]
    [InlineData(15, "101.25 Chinese Yuan")]
    [InlineData(465, "3138.75 Chinese Yuan")]
    [InlineData(4, "27.00 Chinese Yuan")]

    public void Usdcny_GivenUsdAmount_ShouldReturnExpectedChineseYuan(int usd, string expected)
    {
        //Act
        var result = UsdToCny.Usdcny(usd);

        //Assert
        Assert.Equal(expected, result);
    }
}