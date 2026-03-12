using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class MakingSixToastTests
{
    [Fact]

    public void MakingSixToast_GivenANumber_ShouldReturnToastDifference()
    {
        //Arrange
        var inputValue = 6;
        var expectedValue = 0;

        //Act
        var result = MakingSixToast.SixToast(inputValue);
        
        //Assert
        Assert.Equal(expectedValue, result);
    }
}
