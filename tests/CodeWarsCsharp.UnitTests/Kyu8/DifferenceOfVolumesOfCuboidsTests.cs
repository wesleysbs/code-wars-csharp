using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class DifferenceOfVolumesOfCuboidsTests
{
    [Fact]

    public void FindDifference_GivenTwoCuboids_ShouldReturnVolumeDifference()
    {
        //Arrange
        var firstInput = new int[] { 3, 2, 5 };
        var secondInput = new int[] { 1, 4, 4 };

        var expectedResult = 14;

        //Act
        var result = DifferenceOfVolumesOfCuboids.FindDifference(firstInput, secondInput);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}