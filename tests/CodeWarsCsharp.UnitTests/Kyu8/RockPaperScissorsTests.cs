using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class RockPaperScissorsTests
{
    [Theory]
    [InlineData("paper", "paper", "Draw!")]
    [InlineData("scissors", "paper", "Player 1 won!")]
    [InlineData("scissors", "rock", "Player 2 won!")]

    public void RockPaperScissors_GivenTwoStrings_ShouldReturnCorrectResult(string p1, string p2, string expected)
    {
        //Act
        var result = RockPaperScissors.Rps(p1, p2);

        //Assert
        Assert.Equal(expected, result);
    }
}