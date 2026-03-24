using CodeWarsCsharp.Challenges.Kyu8.CenturyFromYear;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class CenturyFromYearTests
{
    [Theory]
    [InlineData(1705, 18)]
    [InlineData(1900, 19)]
    [InlineData(1601, 17)]
    [InlineData(2000, 20)]
    [InlineData(2020, 21)]

    public void CenturyFromYear_GivenAnYear_ShoulReturnCorrectCentury(int year, int expected)
    {
        //Act
        var result = Kata.CenturyFromYear(year);

        //Assert
        Assert.Equal(expected, result);
    }
}
