using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class HowOldWillIBeIn2099Tests
{
    [Theory]
    [InlineData(2003, 2020, "You are 17 years old.")]
    [InlineData(2019, 2020, "You are 1 year old.")]
    [InlineData(2003, 2003, "You were born this very year!")]
    [InlineData(2020, 2003, "You will be born in 17 years.")]
    [InlineData(2020, 2019, "You will be born in 1 year.")]

    public void CalculateAge_GivenBirthYearAndTargetYear_ShouldReturnCorrectMessage(int birth, int yearTo, string expected)
    {
        //Act
        var result = HowOldWillIBeIn2099.CalculateAge(birth, yearTo);

        //Assert
        Assert.Equal(expected, result);
    }
}