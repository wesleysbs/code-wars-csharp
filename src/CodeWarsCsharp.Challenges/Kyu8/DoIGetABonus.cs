using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class DoIGetABonus
{
    public static string BonusTime(int salary, bool bonus)
    {
        return bonus ? $"${salary * 10}" : $"${salary}";
    }
}