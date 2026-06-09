using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class CatYearsDogYearsTests
{
    [Fact]
    public void HumanYearsToAnimalYears_GivenHumanYears_ShouldReturnCorrectCatAndDogYears()
    {
        //Arrange
        var inputValue = 3;
        var expectedResult = new int[] { 3, 28, 29 };

        //Act
        var result = Dinglemouse.humanYearsCatYearsDogYears(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
