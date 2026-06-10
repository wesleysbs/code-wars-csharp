using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8.Collinearity;

public class Kata
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
        return x1 * y2 == y1 * x2;
    }
}

