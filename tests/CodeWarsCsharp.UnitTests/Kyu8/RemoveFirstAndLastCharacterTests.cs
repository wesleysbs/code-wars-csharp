using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class RemoveFirstAndLastCharacterTests
{
    [Theory]
    [InlineData("eloquent", "loquen")]
    [InlineData("ab", "")]
    [InlineData("xyz", "y")]

    public void RemoveChar_GivenAString_ShouldRemoveFirstAndLastCharacters (string s, string expected)
    {
        //Act
        var result = RemoveFirstAndLastCharacter.RemoveChar(s);

        //Assert
        Assert.Equal(expected, result);
    }
}