using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ReturningStringsTests
{
    [Theory]
    [InlineData("Ryan", "Hello, Ryan how are you doing today?")]
    [InlineData("Emma", "Hello, Emma how are you doing today?")]
    [InlineData("William", "Hello, William how are you doing today?")]

    public void Greet_GivenAName_ShouldReturnCorrectMessage(string name, string expected)
    {
        //Act
        var result = ReturningStrings.Greet(name);

        //Assert
        Assert.Equal(expected, result);
    }
}