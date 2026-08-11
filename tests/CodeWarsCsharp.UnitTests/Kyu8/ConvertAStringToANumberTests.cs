using CodeWarsCsharp.Challenges.Kyu8;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class ConvertAStringToANumberTests
{
    [Theory]
    [InlineData("1234", 1234)]
    [InlineData("0", 0)]
    [InlineData("-7", -7)]
    public void StringToNumber_GivenNumericString_ShouldReturnCorrectNumber(string str, int expected)
    {
        //Act
        var result = ConvertAStringToANumber.StringToNumber(str);

        //Assert
        Assert.Equal(expected, result);
    }
}