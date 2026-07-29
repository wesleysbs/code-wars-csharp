using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class FakeBinaryTests
{
    [Theory]
    [InlineData("45385593107843568", "01011110001100111")]
    [InlineData("509321967506747", "101000111101101")]
    [InlineData("366058562030849490134388085", "011011110000101010000011011")]

    public void FakeBin_GivenStringOfDigits_ShouldReturnCorrectBinary(string digits, string expected)
    {
        //Act
        var result = FakeBinary.FakeBin(digits);

        //Assert
        Assert.Equal(expected, result);
    }
}