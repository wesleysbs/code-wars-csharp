using CodeWarsCsharp.Challenges.Kyu8;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.UnitTests.Kyu8;

public class GrasshopperTerminalGameCombatFunctionTests
{
    [Theory]
    [InlineData(100.0, 5.0, 95.0)]
    [InlineData(92.0, 8.0, 84.0)]
    [InlineData(20.0, 30.0, 0.0)]

    public void GameCombat_GivenHealthAndDamage_ShouldReturnRemainingHealth(float health, float damage, float expected)
    {
        //Act
        var result = Game.Combat(health, damage);

        //Assert
        Assert.Equal(expected, result);
    }
}
