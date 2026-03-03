using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SimpleMultiplicationTests
{
    [Theory]
    [InlineData(1, 9)]
    [InlineData(2, 16)]

    public void Multiply_GivenAnInteger_ShouldReturnMultipliedValue(int inputValue, int expectedValue)
    {
        //Act
        var result = SimpleMultiplication.Multiply(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);       
    }
}
