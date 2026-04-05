using CodeWarsCsharp.Challenges.Kyu8.FinalGrade;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class StudentsFinalGradeTests
{
    [Theory]
    [InlineData(100, 12, 100)]
    [InlineData(85, 5, 90)]

    public void StudentsFinalGrade_GivenExamsAndProjects_ShouldReturnCorrectGrade(int exam, int projects, int expected)
    {
        //Act
        var result = Kata.FinalGrade(exam, projects);

        //Assert
        Assert.Equal(expected, result);
    }
}
