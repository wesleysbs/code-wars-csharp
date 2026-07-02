using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class WillThereBeEnoughSpaceTests
{
    [Theory]
    [InlineData(10, 5, 5, 0)]
    [InlineData(100, 60, 50, 10)]
    [InlineData(20, 5, 5, 0)]

    public void Enough_GivenBusCapacityAndPassengers_ShouldReturnPassengersUnableToBoard(int cap, int on, int wait, int expected)
    {
        //Act
        var result = WillThereBeEnoughSpace.Enough(cap, on, wait);

        //Assert
        Assert.Equal(expected, result);
    }
}