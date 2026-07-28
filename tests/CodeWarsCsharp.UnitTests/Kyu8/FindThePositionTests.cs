using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class FindThePositionTests
{
    [Theory]
    [InlineData('a', "Position of alphabet: 1")]
    [InlineData('z', "Position of alphabet: 26")]
    [InlineData('k', "Position of alphabet: 11")]

    public void Position_GivenACharacter_ShouldReturnItsPositionInAlphabet(char alphabet, string expected)
    {
        //Act
        var result = FindThePosition.Position(alphabet);

        //Assert
        Assert.Equal(expected, result);
    }
}