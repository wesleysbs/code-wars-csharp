using CodeWarsCsharp.Challenges.Kyu8.SameCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class CheckSameCaseTests
{
    [Theory]
    [InlineData('a', 'u', 1)]
    [InlineData('a', 'U', 0)]
    [InlineData('a', '*', -1)]

    public void CheckSameCase_GivenTwoCharacters_ShouldReturnExpectedResult(char a, char b, int expected)
    {
        //Act
        var result = Kata.SameCase(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
}
