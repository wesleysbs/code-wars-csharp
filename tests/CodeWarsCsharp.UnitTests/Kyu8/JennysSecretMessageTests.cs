using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class JennysSecretMessageTests
{
    [Theory]
    [InlineData("Jim", "Hello, Jim!")]
    [InlineData("Johnny", "Hello, my love!")]
    [InlineData("Jane", "Hello, Jane!")]

    public void Greet_GivenAName_ShouldReturnCorrectMessage(string name, string expected)
    {
        //Act
        var result = JennysSecretMessage.Greet(name);

        //Assert
        Assert.Equal(expected, result);
    }
}