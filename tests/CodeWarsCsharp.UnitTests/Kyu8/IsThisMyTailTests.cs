using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class IsThisMyTailTests
{
    [Theory]
    [InlineData("Fox", "x", true)]
    [InlineData("Emu", "t", false)]
    [InlineData("Rhino", "o", true)]
    [InlineData("Giraffe", "d", false)]


    public void CorrectTail_GivenBodyAndTail_ShouldReturnExpectedResult(string body, string tail, bool expected)
    {
        //Act
        var result = IsThisMyTail.CorrectTail(body, tail);

        //Assert
        Assert.Equal(expected, result);
    }
}