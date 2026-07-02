using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SimpleCalculatorTests
{
    [Theory]
    [InlineData(6, 2, '+', 8)]
    [InlineData(4, 3, '-', 1)]
    [InlineData(5, 5, '*', 25)]
    [InlineData(5, 4, '/', 1.25)]

    public void Calculator_GivenTwoNumbersAndOperator_ShouldReturnCorrectResult(double a, double b, char op, double expected)
    {
        //Act
        var result = SimpleCalculator.Calculator(a, b, op);

        //Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Calculator_GivenInvalidOperator_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            SimpleCalculator.Calculator(1, 2, '&'));
    }
}