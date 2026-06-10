using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class DoYouSpeakEnglishTests
{
    [Theory]
    [InlineData("hello world", false)]
    [InlineData("englishENGLISHEnGlISHENglisH", true)]
    [InlineData("egnlish", false)]
    [InlineData("eNgliSh", true)]
    [InlineData("", false)]
    [InlineData("1234#$%%eNglish ;k9", true)]

    public void SpeakEnglish_GivenInputString_ShouldDetectEnglishWord(string inputValue, bool expected)
    {
        //Act
        var result = DoYouSpeakEnglish.SpeakEnglish(inputValue);

        //Assert
        Assert.Equal(result, expected);
    }
}
