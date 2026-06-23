using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class CapitalizationAndMutabilityTests
{
    [Theory]
    [InlineData("word","Word")]
    [InlineData("i","I")]
    [InlineData("Hello", "Hello")]

    public void CapitalizeWord_GivenAWord_ShouldCapitalizeFirstLetter(string word, string expected)
    {
        //Act
        var result = CapitalizationAndMutability.CapitalizeWord(word);

        //Assert
        Assert.Equal(expected, result);
    }
}