using CodeWarsCsharp.Challenges.Kyu8.MultiplicationTableForNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class MultiplicationTableForNumberTests
{
    [Theory]
    [InlineData(1,"1 * 1 = 1\n2 * 1 = 2\n3 * 1 = 3\n4 * 1 = 4\n5 * 1 = 5\n6 * 1 = 6\n7 * 1 = 7\n8 * 1 = 8\n9 * 1 = 9\n10 * 1 = 10")]
    [InlineData(5,"1 * 5 = 5\n2 * 5 = 10\n3 * 5 = 15\n4 * 5 = 20\n5 * 5 = 25\n6 * 5 = 30\n7 * 5 = 35\n8 * 5 = 40\n9 * 5 = 45\n10 * 5 = 50")]

    public void MultiplicationTable_GivenAnInteger_ShouldReturnCorrectMultiplicationTable(int number, string expected)
    {
        //Act
        var result = MultiplicationTableForNumberKata.MultiTable(number);

        //Assert
        Assert.Equal(expected, result);
    }
}
