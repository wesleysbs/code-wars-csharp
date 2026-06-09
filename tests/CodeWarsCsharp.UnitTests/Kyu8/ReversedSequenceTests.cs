using CodeWarsCsharp.Challenges.Kyu8.ReversedSequence;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ReversedSequenceTests
{
    [Fact]
    public void ReverseSeq_GivenPositiveInteger_ShouldReturnDescendingSequence()
    {
        //Arrange
        var inputValue = 5;
        var expectedResult = new int[] {5,4,3,2,1};

        //Act
        var result = Kata.ReverseSeq(inputValue);

        //Assert
        Assert.Equal(expectedResult, result);
    }
}
