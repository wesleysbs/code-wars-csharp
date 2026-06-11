using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class GravityFlipTest
{
    [Fact]

    public void Flip_GivenRightDirectionAndColumns_ShouldReturnExpectedOrder()
    {
        //Arrange
        var inputValue = 'R';
        var inputArray = new int[] { 3, 2, 1, 2 };
        var expectedResult = new int[] { 1, 2, 2, 3 };

        //Act
        var result = GravityFlip.Flip(inputValue, inputArray);

        //Assert
        Assert.Equal(expectedResult, result);
   }

    [Fact]

    public void Flip_GivenLeftDirectionAndColumns_ShouldReturnExpectedOrder()
    {
        //Arrange
        var inputValue = 'L';
        var inputArray = new int[] { 1, 4, 5, 3, 5 };
        var expectedResult = new int[] { 5, 5, 4, 3, 1 };

        //Act
        var result = GravityFlip.Flip(inputValue, inputArray);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}