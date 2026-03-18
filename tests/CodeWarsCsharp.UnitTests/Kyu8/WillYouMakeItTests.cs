using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class WillYouMakeItTests
{
    [Theory]
    [InlineData(50, 25, 2, true)]
    [InlineData(100, 50, 1, false)]

    public void ZeroFuel_GivenValidInputs_ShouldReturnTrueIfCarCanReachPump(double distanceToPump, double mpg, double fuelLeft, bool expected)
    {
        //Act
        var result = WillYouMakeIt.ZeroFuel(distanceToPump, mpg, fuelLeft);

        //Assert
        Assert.Equal(expected, result);
    }
}
