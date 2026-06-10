using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class FiveWithoutNumbersTests
{
    [Fact]
    public void UnusualFive_WhenCalled_ShouldReturnFive() 
    {
        //Act
        var result = FiveWithoutNumbers.UnusualFive();

        //Assert
        Assert.Equal(5, result);
    }
}
