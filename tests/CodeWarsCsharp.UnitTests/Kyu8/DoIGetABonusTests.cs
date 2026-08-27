using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class DoIGetABonusTests
{
    [Theory]
    [InlineData(10000, true, "$100000")]
    [InlineData(78, false, "$78")]
    [InlineData(2, true, "$20")]
    [InlineData(60000, false, "$60000")]

    public void BonusTime_GivenASalaryAndBonus_ShouldReturnTheCorrectSalary(int salary, bool bonus, string expected)
    {
        //Act
        var result = DoIGetABonus.BonusTime(salary, bonus);

        //Assert
        Assert.Equal(expected, result);
    }
}