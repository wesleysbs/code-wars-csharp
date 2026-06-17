using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class TheFallingSpeedOfPetals
{
    public static double SakuraFall(double v)
    {
        if (v <= 0)
        {
            return 0;
        }

        return 400.0 / v;
    }
}