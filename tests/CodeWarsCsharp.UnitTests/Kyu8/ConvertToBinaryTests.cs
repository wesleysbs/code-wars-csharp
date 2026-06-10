using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ConvertToBinaryTests
{
    [Theory]
    [InlineData(5,101)]
    [InlineData(3,11)]

    public void ConvertToBinary_GivenAnInteger_ShouldReturnCorrectBinaryValue(int inputValue, int expected)
    {
        //Act
        var result = ConvertToBinary.ToBinary(inputValue);

        //Assert
        Assert.Equal(expected, result);
    }
}
