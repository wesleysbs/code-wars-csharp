using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class AreaOrPerimeterTests
{
    [Theory]
    [InlineData(4, 4, 16)]
    [InlineData(6, 10, 32)]

    public void AreaOrPerimeter_GivenLengthAndWidth_ShouldReturnCorrectResult(int length, int width, int expected)
    {
        //Act
        var result = MathCheck.AreaOrPerimeter(length, width);

        //Assert
        Assert.Equal(expected, result);
    }
}
