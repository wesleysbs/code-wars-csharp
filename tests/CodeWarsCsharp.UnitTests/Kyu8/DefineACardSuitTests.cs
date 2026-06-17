using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class DefineACardSuitTests
{
    [Theory]
    [InlineData("3♣", "clubs")]
    [InlineData("Q♠", "spades")]
    [InlineData("9♦", "diamonds")]
    [InlineData("J♥", "hearts")]

    public void DefineSuit_GivenCard_ShouldReturnExpectedSuit(string card, string expected)
    {
        //Act
        var result = DefineACardSuit.DefineSuit(card);

        //Assert
        Assert.Equal(expected, result);
    }
}