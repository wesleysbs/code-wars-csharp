using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class RemoveStringSpacesTests
{
    [Theory]
    [InlineData("8 j 8   mBliB8g  imjB8B8  jl  B", "8j8mBliB8gimjB8B8jlB")]
    [InlineData("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd", "88Bifk8hB8BB8BBBB888chl8BhBfd")]
    [InlineData("8aaaaa dddd r     ", "8aaaaaddddr")]

    public void NoSpace_GivenStringWithSpaces_ShouldReturnStringWithoutSpaces(string input, string expected)
    {
        //Act
        var result = RemoveStringSpaces.NoSpace(input);

        //Assert
        Assert.Equal(expected, result);
    }
}