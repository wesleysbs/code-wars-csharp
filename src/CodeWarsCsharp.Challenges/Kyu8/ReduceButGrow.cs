using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsCsharp.Challenges.Kyu8;

public class ReduceButGrow
{
    public static int Grow(int[] x)
    {
        int grow = 1;
        for (int i = 0; i < x.Length; i++)
        {
            grow = grow * x[i];
        }
        return grow;
    }
}
