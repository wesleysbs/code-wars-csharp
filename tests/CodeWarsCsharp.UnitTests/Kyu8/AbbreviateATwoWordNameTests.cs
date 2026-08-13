using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class AbbreviateATwoWordNameTests
{
    [Theory]
    [InlineData("Sam Harris", "S.H")]
    [InlineData("patrick feenan", "P.F")]
    [InlineData("P Favuzzi", "P.F")]

    public void AbbrevName_GivenAName_ShouldReturnTheInitials(string name, string expected)
    {
        //Act
        var result = AbbreviateATwoWordName.AbbrevName(name);

        //Assert
        Assert.Equal(expected, result);
    }
}