using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ConvertANumberToAStringTests
{
    [Theory]
    [InlineData(123, "123")]
    [InlineData(0, "0")]
    [InlineData(-5, "-5")]

    public void NumberToString_GivenInteger_ShouldConvertToAString(int num, string expected)
    {
        //Act
        var result = ConvertANumberToAString.NumberToString(num);

        //Assert
        Assert.Equal(expected, result);
    }
}