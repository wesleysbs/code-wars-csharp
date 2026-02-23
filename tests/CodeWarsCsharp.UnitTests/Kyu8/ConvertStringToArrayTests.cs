using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ConvertStringToArrayTests
{
    [Fact] 
    public void StringToArray_GivenAString_ShouldReturnExpectedArray()
    {
        //Arrange
        var inputStringValue = "Wesley moto";
        var expectedResult = new string[] { "Wesley", "moto" };

        //Act
        var result = ConvertStringToArray.StringToArray(inputStringValue);
      
        //Assert
        Assert.Equal(expectedResult, result);
    }  
}
