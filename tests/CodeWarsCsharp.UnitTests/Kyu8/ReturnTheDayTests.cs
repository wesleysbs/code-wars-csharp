using CodeWarsCsharp.Challenges.Kyu8.ReturnTheDay;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ReturnTheDayTests
{
    [Theory]
    [InlineData(1, "Sunday")]
    [InlineData(2, "Monday")]
    [InlineData(3, "Tuesday")]
    [InlineData(4, "Wednesday")]
    [InlineData(5, "Thursday")]
    [InlineData(6, "Friday")]
    [InlineData(7, "Saturday")]
    [InlineData(8, "Wrong, please enter a number between 1 and 7")]
    [InlineData(0, "Wrong, please enter a number between 1 and 7")]
    [InlineData(-1, "Wrong, please enter a number between 1 and 7")]
    [InlineData(20, "Wrong, please enter a number between 1 and 7")]

    public void ReturnTheDay_GivenANumber_ShouldReturnCorrectDayOfTheWeek(int number, string expected)
    {
        //Act
        var result = Kata.WhatDay(number);

        //Assert
        Assert.Equal(expected, result);
    }
}
