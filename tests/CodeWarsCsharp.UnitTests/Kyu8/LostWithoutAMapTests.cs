using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class LostWithoutAMapTests
{
    [Fact]

    public void Maps_GivenArray_ShouldReturnDoubledArray()
    {
        //Arrange
        var inputValue = new int[] { 1, 2, 3 };
        var expectedResult = new int[] { 2, 4, 6 };

        //Act
        var result = LostWithoutAMap.Maps(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
