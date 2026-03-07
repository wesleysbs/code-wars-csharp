using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class VolumeOfACuboidTests
{
    [Fact]

    public void GetVolumeOfCuboid_GivenDimensions_ShouldReturnCorrectVolume()
    {
        //Arrange
        const int length = 2;
        const int width = 5;
        const int height = 6;
        
        const int expectedValue = 60;

        //Act
        var result = VolumeOfACuboid.GetVolumeOfCuboid(length, width, height);

        //Assert
        Assert.Equal(expectedValue, result);
    }
}
