using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class MakeUpperCaseTests
{
    [Fact]

    public void MakeUpperCase_GivenAString_ShouldReturnUpperCase()
    {
        //Arrange
        var inputValue = "hello";
        var expectedValue = "HELLO";

        //Act
        var result = Kata.MakeUpperCase(inputValue);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
