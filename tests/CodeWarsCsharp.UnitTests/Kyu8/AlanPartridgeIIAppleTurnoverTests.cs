using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class AlanPartridgeIIAppleTurnoverTests
{
    [Theory]

    [InlineData("50", "It's hotter than the sun!!")]
    [InlineData(4, "Help yourself to a honeycomb Yorkie for the glovebox.")]
    [InlineData(31, "Help yourself to a honeycomb Yorkie for the glovebox.")]
    [InlineData(32, "It's hotter than the sun!!")]
    [InlineData(10.0, "Help yourself to a honeycomb Yorkie for the glovebox.")]
    
    public void Apple_GivenAnObject_ShouldReturnCorrectMessage(object n, string expected)
    {
        //Act
        var result = AlanPartridgeIIAppleTurnover.Apple(n);

        //Assert
        Assert.Equal(expected, result);
    }
}