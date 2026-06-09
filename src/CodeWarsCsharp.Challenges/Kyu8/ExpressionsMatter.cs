using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsCsharp.Challenges.Kyu8.ExpressionsMatter;

public class Kata
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
        int v1 = a + b + c;
        int v2 = a * b * c;
        int v3 = (a + b) * c;
        int v4 = a * (b + c);

        int max = new int[] { v1, v2, v3, v4 }.Max();
        return max;
    }
}
