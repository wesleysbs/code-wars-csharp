using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SentenceSmashTests
{
    [Fact]
    public void Smash_GivenAnArray_ShouldReturnSentence()
    {
        //Arrange
        var inputValue = new string[] { "hello", "world", "this", "is", "great" };
        var expectedResult = "hello world this is great";

        //Act
        var result = SentenceSmash.Smash(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Smash_GivenTwoWords_ShouldReturnSentence()
    {
        //Arrange
        var inputValue = new string[] { "hello", "world" };
        var expectedResult = "hello world";

        //Act
        var result = SentenceSmash.Smash(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Smash_GivenOneWord_ShouldReturnTheSameWord()
    {
        //Arrange
        var inputValue = new string[] { "hello" };
        var expectedResult = "hello";

        //Act
        var result = SentenceSmash.Smash(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}