using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class FindOutWhetherTheShapeIsACubeTests
{
    [Theory]
    [InlineData(0.0, 0.0, false)]
    [InlineData(8.0, 2.0, true)]
    [InlineData(2.0, 1.0, false)]
    
    public void IsACube_GivenVolumeAndSide_ShouldReturnTrueOrFalse(double volume, double size, bool expected)
    {
        //Arrange
        var cubeChecker = new CubeChecker();
        
        //Act
        var result = cubeChecker.IsCube(volume, size);

        //Assert
        Assert.Equal(expected, result);
    }
}
