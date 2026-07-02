using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class SeatsInTheaterTests
{
    [Theory]
    [InlineData(16, 11, 5, 3, 96)]
    [InlineData(1, 1, 1, 1, 0)]
    [InlineData(1000, 1000, 1000, 1000, 0)]
    [InlineData(13, 6, 8, 3, 18)]

    public void TheaterSeats_GivenPosition_ShouldReturnNumberOfPeopleAffected(int nCols, int nRows, int col, int row, int expected)
    {
        //Act
        var result = SeatsInTheater.Seats(nCols, nRows, col, row);

        //Assert
        Assert.Equal(expected, result);
    }
}