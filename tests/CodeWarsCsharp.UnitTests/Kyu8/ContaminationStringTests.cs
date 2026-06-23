using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ContaminationStringTests
{
    [Theory]
    [InlineData("abc", "z", "zzz")]
    [InlineData("", "z", "")]
    [InlineData("abc", "", "")]
    [InlineData("a", "z", "z")]
    [InlineData("abc", "!", "!!!")]
    [InlineData("aaaaa", "x", "xxxxx")]

    public void Contamination_GivenValidInputs_ShouldReturnContaminatedText(string text, string character, string expected)
    {
        //Act
        var result = ContaminationString.Contamination(text, character);

        //Assert
        Assert.Equal(expected, result);
    }
}