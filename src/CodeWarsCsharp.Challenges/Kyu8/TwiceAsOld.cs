using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

using System;

public class TwiceAsOldSolution
{
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
        return Math.Abs(dadYears - (2 * sonYears));
    }
}