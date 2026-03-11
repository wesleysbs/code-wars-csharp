using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ArrayPlusArrayTests
{
    [Fact]
    public void SumArrays_GivenTwoArrays_ShouldReturnCorrectSum()
    {
        //Arrange
        var firstInput = new int[] { 1, 2, 3 };
        var secondInput = new int[] { 4, 5, 6 };

        var expectedResult = 21;
        
        //Act
        var result = ArrayPlusArray.SumArrays(firstInput, secondInput);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
