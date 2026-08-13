using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class IsNDivisibleByXAndY
{
    public static bool IsDivisible(int n, int x, int y)
    {
        return n % x == 0 && n % y == 0;
    }
}