using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class BasicMathematicalOperationsTests
{
    [Theory]
    [InlineData('+', 4, 7, 11)]
    [InlineData('-', 15, 18, -3)]
    [InlineData('*', 5, 5, 25)]
    [InlineData('/', 49, 7, 7)]

    public void BasicOp_GivenAnOperation_ShouldReturnCorrectCalculation(char operation, double value1, double value2, double expected)
    {
        //Act
        var result = BasicMathematicalOperations.BasicOp(operation, value1, value2);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]

    public void BasicOp_GivenInvalidOperation_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            BasicMathematicalOperations.BasicOp('%', 5, 3));
    }
}